
import {fetchData,getAccessControlInfo, getAccessScope, baseUrl} from './webAPIBase';

let activeScope = {};

export function setAccessScope(scope) {
    activeScope = {
        ...activeScope,
        ...scope,
    }
}

export function GetAuthCol(accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetAuthCol'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetAuthRow(accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetAuthRow'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )

}
export function GetScreenLabel(accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetScreenLabel'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope || getAccessScope())
        }
    )

}

export function GetLabels(labelCat,accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetLabels'
        ,{
            requestOptions: {
                body: JSON.stringify({
                    labelCat:labelCat
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}

export function GetSystemLabels(labelCat,accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetSystemLabels'
        ,{
            requestOptions: {
                body: JSON.stringify({
                    labelCat:labelCat
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}

export function GetScreenButtonHlp(labelCat,accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetScreenButtonHlp'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetScreenHlp(labelCat,accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetScreenHlp'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetScreenCriteria(accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetScreenCriteria'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetNewMst(accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetNewMst'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetNewDtl(accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetNewDtl'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetScreenFilter(accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetScreenFilter'
        ,{
            requestOptions: {
                body: JSON.stringify({
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetColumnContent(mstId, dtlId, columnName, isMaster, screenColumnName, accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetColumnContent'
        ,{
            requestOptions: {
                body: JSON.stringify({
                    mstId: mstId || '',
                    dtlId: dtlId || '',
                    screenColumnName: screenColumnName,
                    columnName: columnName,
                    isMaster: isMaster,
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetAdmDatTier107List(searchStr, topN, filterId,accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetAdmDatTier107List'
        ,{
            requestOptions: {
                body: JSON.stringify({
                    searchStr: searchStr || '',
                    topN: topN || 0,
                    filterId: ('' +  (filterId || 0)),
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetAdmDatTier107ById(keyId,accessScope){   
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetAdmDatTier107ById'
        ,{
            requestOptions: {
                body: JSON.stringify({
                    keyId: keyId || '',
                    options: {
                        currentScreenCriteria : JSON.stringify({}),
                    },
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function GetAdmDatTier107DtlById(keyId,filterId,accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetAdmDatTier107DtlById'
        ,{
            requestOptions: {
                body: JSON.stringify({
                    keyId: keyId || '',
                    options: {
                        currentScreenCriteria : JSON.stringify({}),
                    },
                    filterId: filterId || 0,
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}

export function LoadInitPage(options,accessScope) {
    const reqJson = JSON.stringify({
        options: options
    });
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/LoadInitPage'
        ,{
            requestOptions: {
                body: reqJson,
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}
export function SaveData(mst,dtl,options,accessScope){
    const reqJson = JSON.stringify({
        mst: mst,
        dtl: dtl,
        options: options
    });
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/SaveData'
        ,{
            requestOptions: {
                body: reqJson,
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}

export function DelMst(mst,options,accessScope){
    const reqJson = JSON.stringify({
        mst: mst,
        options: options
    });
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/DelMst'
        ,{
            requestOptions: {
                body: reqJson,
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}

export function SetScreenCriteria(criteriaValues, accessScope){
    return fetchData(baseUrl+'/AdmDatTierWs.asmx/SetScreenCriteria'
        ,{
            requestOptions: {
                body: JSON.stringify({
                    criteriaValues: criteriaValues
                }),
            },
            ...(getAccessControlInfo()),
            ...(accessScope)
        }
    )
}

/*screen criteria dll and screen dropdownlist/autocomplete*/           
            export function GetEntityId195List(query, topN, filterBy,accessScope){
return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetEntityId195List'

                                                    ,{
                                                        requestOptions: {
                                                            body: JSON.stringify({
                                                                query: query || '',
                                                                topN: topN || 0,
                                                                filterBy: filterBy || null
                                                            }),
                                                        },
                                                        ...(getAccessControlInfo()),
                                                        ...(accessScope)
                                                    }
                                                )
                                            }
export function GetDbProviderCd195List(query, topN, filterBy,accessScope){
return fetchData(baseUrl+'/AdmDatTierWs.asmx/GetDbProviderCd195List'

                                                    ,{
                                                        requestOptions: {
                                                            body: JSON.stringify({
                                                                query: query || '',
                                                                topN: topN || 0,
                                                                filterBy: filterBy || null
                                                            }),
                                                        },
                                                        ...(getAccessControlInfo()),
                                                        ...(accessScope)
                                                    }
                                                )
                                            }/* ReactRule: Service Custom Function *//* ReactRule End: Service Custom Function */