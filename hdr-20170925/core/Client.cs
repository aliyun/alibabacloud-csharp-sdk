// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Hdr20170925.Models;

namespace AlibabaCloud.SDK.Hdr20170925
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("hdr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        public ChangeRecoveryPointResponse ChangeRecoveryPointWithOptions(ChangeRecoveryPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipAddressId))
            {
                query["EipAddressId"] = request.EipAddressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryCpu))
            {
                query["RecoveryCpu"] = request.RecoveryCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryEssdPerformanceLevel))
            {
                query["RecoveryEssdPerformanceLevel"] = request.RecoveryEssdPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceName))
            {
                query["RecoveryInstanceName"] = request.RecoveryInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceType))
            {
                query["RecoveryInstanceType"] = request.RecoveryInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryIpAddress))
            {
                query["RecoveryIpAddress"] = request.RecoveryIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMemory))
            {
                query["RecoveryMemory"] = request.RecoveryMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointId))
            {
                query["RecoveryPointId"] = request.RecoveryPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointTime))
            {
                query["RecoveryPointTime"] = request.RecoveryPointTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptContent))
            {
                query["RecoveryPostScriptContent"] = request.RecoveryPostScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptType))
            {
                query["RecoveryPostScriptType"] = request.RecoveryPostScriptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryReserveIp))
            {
                query["RecoveryReserveIp"] = request.RecoveryReserveIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseDhcp))
            {
                query["RecoveryUseDhcp"] = request.RecoveryUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseEssd))
            {
                query["RecoveryUseEssd"] = request.RecoveryUseEssd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseSsd))
            {
                query["RecoveryUseSsd"] = request.RecoveryUseSsd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeRecoveryPoint",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeRecoveryPointResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ChangeRecoveryPointResponse> ChangeRecoveryPointWithOptionsAsync(ChangeRecoveryPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipAddressId))
            {
                query["EipAddressId"] = request.EipAddressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryCpu))
            {
                query["RecoveryCpu"] = request.RecoveryCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryEssdPerformanceLevel))
            {
                query["RecoveryEssdPerformanceLevel"] = request.RecoveryEssdPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceName))
            {
                query["RecoveryInstanceName"] = request.RecoveryInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceType))
            {
                query["RecoveryInstanceType"] = request.RecoveryInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryIpAddress))
            {
                query["RecoveryIpAddress"] = request.RecoveryIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMemory))
            {
                query["RecoveryMemory"] = request.RecoveryMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointId))
            {
                query["RecoveryPointId"] = request.RecoveryPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointTime))
            {
                query["RecoveryPointTime"] = request.RecoveryPointTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptContent))
            {
                query["RecoveryPostScriptContent"] = request.RecoveryPostScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptType))
            {
                query["RecoveryPostScriptType"] = request.RecoveryPostScriptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryReserveIp))
            {
                query["RecoveryReserveIp"] = request.RecoveryReserveIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseDhcp))
            {
                query["RecoveryUseDhcp"] = request.RecoveryUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseEssd))
            {
                query["RecoveryUseEssd"] = request.RecoveryUseEssd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseSsd))
            {
                query["RecoveryUseSsd"] = request.RecoveryUseSsd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeRecoveryPoint",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeRecoveryPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ChangeRecoveryPointResponse ChangeRecoveryPoint(ChangeRecoveryPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeRecoveryPointWithOptions(request, runtime);
        }

        public async Task<ChangeRecoveryPointResponse> ChangeRecoveryPointAsync(ChangeRecoveryPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeRecoveryPointWithOptionsAsync(request, runtime);
        }

        public CommitFailoverResponse CommitFailoverWithOptions(CommitFailoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitFailover",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitFailoverResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CommitFailoverResponse> CommitFailoverWithOptionsAsync(CommitFailoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitFailover",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitFailoverResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CommitFailoverResponse CommitFailover(CommitFailoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CommitFailoverWithOptions(request, runtime);
        }

        public async Task<CommitFailoverResponse> CommitFailoverAsync(CommitFailoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CommitFailoverWithOptionsAsync(request, runtime);
        }

        public CreateRecoveryPlanResponse CreateRecoveryPlanWithOptions(CreateRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecoveryPlan",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateRecoveryPlanResponse> CreateRecoveryPlanWithOptionsAsync(CreateRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRecoveryPlan",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateRecoveryPlanResponse CreateRecoveryPlan(CreateRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<CreateRecoveryPlanResponse> CreateRecoveryPlanAsync(CreateRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public CreateSitePairResponse CreateSitePairWithOptions(CreateSitePairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteName))
            {
                query["PrimarySiteName"] = request.PrimarySiteName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteRegionId))
            {
                query["PrimarySiteRegionId"] = request.PrimarySiteRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteType))
            {
                query["PrimarySiteType"] = request.PrimarySiteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteVpcId))
            {
                query["PrimarySiteVpcId"] = request.PrimarySiteVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteZoneId))
            {
                query["PrimarySiteZoneId"] = request.PrimarySiteZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteName))
            {
                query["SecondarySiteName"] = request.SecondarySiteName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteRegionId))
            {
                query["SecondarySiteRegionId"] = request.SecondarySiteRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteType))
            {
                query["SecondarySiteType"] = request.SecondarySiteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteVpcId))
            {
                query["SecondarySiteVpcId"] = request.SecondarySiteVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteZoneId))
            {
                query["SecondarySiteZoneId"] = request.SecondarySiteZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairType))
            {
                query["SitePairType"] = request.SitePairType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSitePair",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSitePairResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSitePairResponse> CreateSitePairWithOptionsAsync(CreateSitePairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteName))
            {
                query["PrimarySiteName"] = request.PrimarySiteName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteRegionId))
            {
                query["PrimarySiteRegionId"] = request.PrimarySiteRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteType))
            {
                query["PrimarySiteType"] = request.PrimarySiteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteVpcId))
            {
                query["PrimarySiteVpcId"] = request.PrimarySiteVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimarySiteZoneId))
            {
                query["PrimarySiteZoneId"] = request.PrimarySiteZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteName))
            {
                query["SecondarySiteName"] = request.SecondarySiteName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteRegionId))
            {
                query["SecondarySiteRegionId"] = request.SecondarySiteRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteType))
            {
                query["SecondarySiteType"] = request.SecondarySiteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteVpcId))
            {
                query["SecondarySiteVpcId"] = request.SecondarySiteVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecondarySiteZoneId))
            {
                query["SecondarySiteZoneId"] = request.SecondarySiteZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairType))
            {
                query["SitePairType"] = request.SitePairType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSitePair",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSitePairResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSitePairResponse CreateSitePair(CreateSitePairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSitePairWithOptions(request, runtime);
        }

        public async Task<CreateSitePairResponse> CreateSitePairAsync(CreateSitePairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSitePairWithOptionsAsync(request, runtime);
        }

        public DeleteRecoveryPlanResponse DeleteRecoveryPlanWithOptions(DeleteRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecoveryPlan",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRecoveryPlanResponse> DeleteRecoveryPlanWithOptionsAsync(DeleteRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRecoveryPlan",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRecoveryPlanResponse DeleteRecoveryPlan(DeleteRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<DeleteRecoveryPlanResponse> DeleteRecoveryPlanAsync(DeleteRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public DeleteSitePairResponse DeleteSitePairWithOptions(DeleteSitePairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSitePair",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSitePairResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSitePairResponse> DeleteSitePairWithOptionsAsync(DeleteSitePairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSitePair",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSitePairResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSitePairResponse DeleteSitePair(DeleteSitePairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSitePairWithOptions(request, runtime);
        }

        public async Task<DeleteSitePairResponse> DeleteSitePairAsync(DeleteSitePairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSitePairWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableInstanceTypesResponse DescribeAvailableInstanceTypesWithOptions(DescribeAvailableInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoOptimized))
            {
                query["IoOptimized"] = request.IoOptimized;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClient))
            {
                query["UserClient"] = request.UserClient;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableInstanceTypes",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableInstanceTypesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAvailableInstanceTypesResponse> DescribeAvailableInstanceTypesWithOptionsAsync(DescribeAvailableInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoOptimized))
            {
                query["IoOptimized"] = request.IoOptimized;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Network))
            {
                query["Network"] = request.Network;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClient))
            {
                query["UserClient"] = request.UserClient;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAvailableInstanceTypes",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableInstanceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAvailableInstanceTypesResponse DescribeAvailableInstanceTypes(DescribeAvailableInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableInstanceTypesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableInstanceTypesResponse> DescribeAvailableInstanceTypesAsync(DescribeAvailableInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableInstanceTypesWithOptionsAsync(request, runtime);
        }

        public DescribeInfrastructuresResponse DescribeInfrastructuresWithOptions(DescribeInfrastructuresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInfrastructures",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInfrastructuresResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInfrastructuresResponse> DescribeInfrastructuresWithOptionsAsync(DescribeInfrastructuresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInfrastructures",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInfrastructuresResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInfrastructuresResponse DescribeInfrastructures(DescribeInfrastructuresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInfrastructuresWithOptions(request, runtime);
        }

        public async Task<DescribeInfrastructuresResponse> DescribeInfrastructuresAsync(DescribeInfrastructuresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInfrastructuresWithOptionsAsync(request, runtime);
        }

        public DescribeRecoveryPlanResponse DescribeRecoveryPlanWithOptions(DescribeRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoveryPlan",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRecoveryPlanResponse> DescribeRecoveryPlanWithOptionsAsync(DescribeRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoveryPlan",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRecoveryPlanResponse DescribeRecoveryPlan(DescribeRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<DescribeRecoveryPlanResponse> DescribeRecoveryPlanAsync(DescribeRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public DescribeRecoveryPlansResponse DescribeRecoveryPlansWithOptions(DescribeRecoveryPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoveryPlans",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoveryPlansResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRecoveryPlansResponse> DescribeRecoveryPlansWithOptionsAsync(DescribeRecoveryPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoveryPlans",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoveryPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRecoveryPlansResponse DescribeRecoveryPlans(DescribeRecoveryPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecoveryPlansWithOptions(request, runtime);
        }

        public async Task<DescribeRecoveryPlansResponse> DescribeRecoveryPlansAsync(DescribeRecoveryPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecoveryPlansWithOptionsAsync(request, runtime);
        }

        public DescribeRecoveryPointsResponse DescribeRecoveryPointsWithOptions(DescribeRecoveryPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoveryPoints",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoveryPointsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRecoveryPointsResponse> DescribeRecoveryPointsWithOptionsAsync(DescribeRecoveryPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoveryPoints",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoveryPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRecoveryPointsResponse DescribeRecoveryPoints(DescribeRecoveryPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecoveryPointsWithOptions(request, runtime);
        }

        public async Task<DescribeRecoveryPointsResponse> DescribeRecoveryPointsAsync(DescribeRecoveryPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecoveryPointsWithOptionsAsync(request, runtime);
        }

        public DescribeServerResponse DescribeServerWithOptions(DescribeServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServer",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServerResponse> DescribeServerWithOptionsAsync(DescribeServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServer",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServerResponse DescribeServer(DescribeServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServerWithOptions(request, runtime);
        }

        public async Task<DescribeServerResponse> DescribeServerAsync(DescribeServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServerWithOptionsAsync(request, runtime);
        }

        public DescribeServersResponse DescribeServersWithOptions(DescribeServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIds))
            {
                query["ServerIds"] = request.ServerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServers",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServersResponse> DescribeServersWithOptionsAsync(DescribeServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerIds))
            {
                query["ServerIds"] = request.ServerIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServers",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServersResponse DescribeServers(DescribeServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServersWithOptions(request, runtime);
        }

        public async Task<DescribeServersResponse> DescribeServersAsync(DescribeServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServersWithOptionsAsync(request, runtime);
        }

        public DescribeSiteResponse DescribeSiteWithOptions(DescribeSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSite",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSiteResponse> DescribeSiteWithOptionsAsync(DescribeSiteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                query["SiteId"] = request.SiteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSite",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSiteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSiteResponse DescribeSite(DescribeSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSiteWithOptions(request, runtime);
        }

        public async Task<DescribeSiteResponse> DescribeSiteAsync(DescribeSiteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSiteWithOptionsAsync(request, runtime);
        }

        public DescribeSitePairResponse DescribeSitePairWithOptions(DescribeSitePairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSitePair",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSitePairResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSitePairResponse> DescribeSitePairWithOptionsAsync(DescribeSitePairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSitePair",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSitePairResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSitePairResponse DescribeSitePair(DescribeSitePairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSitePairWithOptions(request, runtime);
        }

        public async Task<DescribeSitePairResponse> DescribeSitePairAsync(DescribeSitePairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSitePairWithOptionsAsync(request, runtime);
        }

        public DescribeSitePairStatisticsResponse DescribeSitePairStatisticsWithOptions(DescribeSitePairStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSitePairStatistics",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSitePairStatisticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSitePairStatisticsResponse> DescribeSitePairStatisticsWithOptionsAsync(DescribeSitePairStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSitePairStatistics",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSitePairStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSitePairStatisticsResponse DescribeSitePairStatistics(DescribeSitePairStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSitePairStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeSitePairStatisticsResponse> DescribeSitePairStatisticsAsync(DescribeSitePairStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSitePairStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeSitePairsResponse DescribeSitePairsWithOptions(DescribeSitePairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairType))
            {
                query["SitePairType"] = request.SitePairType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSitePairs",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSitePairsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSitePairsResponse> DescribeSitePairsWithOptionsAsync(DescribeSitePairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairType))
            {
                query["SitePairType"] = request.SitePairType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSitePairs",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSitePairsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSitePairsResponse DescribeSitePairs(DescribeSitePairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSitePairsWithOptions(request, runtime);
        }

        public async Task<DescribeSitePairsResponse> DescribeSitePairsAsync(DescribeSitePairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSitePairsWithOptionsAsync(request, runtime);
        }

        public DescribeSummaryResponse DescribeSummaryWithOptions(DescribeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSummary",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSummaryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSummaryResponse> DescribeSummaryWithOptionsAsync(DescribeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSummary",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSummaryResponse DescribeSummary(DescribeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeSummaryResponse> DescribeSummaryAsync(DescribeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeTaskResponse DescribeTaskWithOptions(DescribeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTask",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTaskResponse> DescribeTaskWithOptionsAsync(DescribeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTask",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTaskWithOptions(request, runtime);
        }

        public async Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTaskWithOptionsAsync(request, runtime);
        }

        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTasksResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTasks",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTasksWithOptions(request, runtime);
        }

        public async Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTasksWithOptionsAsync(request, runtime);
        }

        public DisableReplicationResponse DisableReplicationWithOptions(DisableReplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableReplication",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableReplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableReplicationResponse> DisableReplicationWithOptionsAsync(DisableReplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableReplication",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableReplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableReplicationResponse DisableReplication(DisableReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableReplicationWithOptions(request, runtime);
        }

        public async Task<DisableReplicationResponse> DisableReplicationAsync(DisableReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableReplicationWithOptionsAsync(request, runtime);
        }

        public EnableReplicationResponse EnableReplicationWithOptions(EnableReplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrashConsistentPointPolicy))
            {
                query["CrashConsistentPointPolicy"] = request.CrashConsistentPointPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationNetwork))
            {
                query["ReplicationNetwork"] = request.ReplicationNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationUseEssd))
            {
                query["ReplicationUseEssd"] = request.ReplicationUseEssd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationUseSsd))
            {
                query["ReplicationUseSsd"] = request.ReplicationUseSsd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableReplication",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableReplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableReplicationResponse> EnableReplicationWithOptionsAsync(EnableReplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrashConsistentPointPolicy))
            {
                query["CrashConsistentPointPolicy"] = request.CrashConsistentPointPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationNetwork))
            {
                query["ReplicationNetwork"] = request.ReplicationNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationUseEssd))
            {
                query["ReplicationUseEssd"] = request.ReplicationUseEssd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationUseSsd))
            {
                query["ReplicationUseSsd"] = request.ReplicationUseSsd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableReplication",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableReplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableReplicationResponse EnableReplication(EnableReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableReplicationWithOptions(request, runtime);
        }

        public async Task<EnableReplicationResponse> EnableReplicationAsync(EnableReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableReplicationWithOptionsAsync(request, runtime);
        }

        public FailbackResponse FailbackWithOptions(FailbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryCpu))
            {
                query["RecoveryCpu"] = request.RecoveryCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInfrastructureId))
            {
                query["RecoveryInfrastructureId"] = request.RecoveryInfrastructureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceName))
            {
                query["RecoveryInstanceName"] = request.RecoveryInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceType))
            {
                query["RecoveryInstanceType"] = request.RecoveryInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryIpAddress))
            {
                query["RecoveryIpAddress"] = request.RecoveryIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMemory))
            {
                query["RecoveryMemory"] = request.RecoveryMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointId))
            {
                query["RecoveryPointId"] = request.RecoveryPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptContent))
            {
                query["RecoveryPostScriptContent"] = request.RecoveryPostScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptType))
            {
                query["RecoveryPostScriptType"] = request.RecoveryPostScriptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryReserveIp))
            {
                query["RecoveryReserveIp"] = request.RecoveryReserveIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseDhcp))
            {
                query["RecoveryUseDhcp"] = request.RecoveryUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Failback",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailbackResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FailbackResponse> FailbackWithOptionsAsync(FailbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryCpu))
            {
                query["RecoveryCpu"] = request.RecoveryCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInfrastructureId))
            {
                query["RecoveryInfrastructureId"] = request.RecoveryInfrastructureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceName))
            {
                query["RecoveryInstanceName"] = request.RecoveryInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceType))
            {
                query["RecoveryInstanceType"] = request.RecoveryInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryIpAddress))
            {
                query["RecoveryIpAddress"] = request.RecoveryIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMemory))
            {
                query["RecoveryMemory"] = request.RecoveryMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointId))
            {
                query["RecoveryPointId"] = request.RecoveryPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptContent))
            {
                query["RecoveryPostScriptContent"] = request.RecoveryPostScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptType))
            {
                query["RecoveryPostScriptType"] = request.RecoveryPostScriptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryReserveIp))
            {
                query["RecoveryReserveIp"] = request.RecoveryReserveIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseDhcp))
            {
                query["RecoveryUseDhcp"] = request.RecoveryUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Failback",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FailbackResponse Failback(FailbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FailbackWithOptions(request, runtime);
        }

        public async Task<FailbackResponse> FailbackAsync(FailbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FailbackWithOptionsAsync(request, runtime);
        }

        public ForcedFailoverResponse ForcedFailoverWithOptions(ForcedFailoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipAddressId))
            {
                query["EipAddressId"] = request.EipAddressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryCpu))
            {
                query["RecoveryCpu"] = request.RecoveryCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryEssdPerformanceLevel))
            {
                query["RecoveryEssdPerformanceLevel"] = request.RecoveryEssdPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceName))
            {
                query["RecoveryInstanceName"] = request.RecoveryInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceType))
            {
                query["RecoveryInstanceType"] = request.RecoveryInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryIpAddress))
            {
                query["RecoveryIpAddress"] = request.RecoveryIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMemory))
            {
                query["RecoveryMemory"] = request.RecoveryMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointId))
            {
                query["RecoveryPointId"] = request.RecoveryPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointTime))
            {
                query["RecoveryPointTime"] = request.RecoveryPointTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptContent))
            {
                query["RecoveryPostScriptContent"] = request.RecoveryPostScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptType))
            {
                query["RecoveryPostScriptType"] = request.RecoveryPostScriptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryReserveIp))
            {
                query["RecoveryReserveIp"] = request.RecoveryReserveIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseDhcp))
            {
                query["RecoveryUseDhcp"] = request.RecoveryUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseEssd))
            {
                query["RecoveryUseEssd"] = request.RecoveryUseEssd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseSsd))
            {
                query["RecoveryUseSsd"] = request.RecoveryUseSsd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForcedFailover",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForcedFailoverResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ForcedFailoverResponse> ForcedFailoverWithOptionsAsync(ForcedFailoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipAddressId))
            {
                query["EipAddressId"] = request.EipAddressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryCpu))
            {
                query["RecoveryCpu"] = request.RecoveryCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryEssdPerformanceLevel))
            {
                query["RecoveryEssdPerformanceLevel"] = request.RecoveryEssdPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceName))
            {
                query["RecoveryInstanceName"] = request.RecoveryInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceType))
            {
                query["RecoveryInstanceType"] = request.RecoveryInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryIpAddress))
            {
                query["RecoveryIpAddress"] = request.RecoveryIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMemory))
            {
                query["RecoveryMemory"] = request.RecoveryMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointId))
            {
                query["RecoveryPointId"] = request.RecoveryPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointTime))
            {
                query["RecoveryPointTime"] = request.RecoveryPointTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptContent))
            {
                query["RecoveryPostScriptContent"] = request.RecoveryPostScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptType))
            {
                query["RecoveryPostScriptType"] = request.RecoveryPostScriptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryReserveIp))
            {
                query["RecoveryReserveIp"] = request.RecoveryReserveIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseDhcp))
            {
                query["RecoveryUseDhcp"] = request.RecoveryUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseEssd))
            {
                query["RecoveryUseEssd"] = request.RecoveryUseEssd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseSsd))
            {
                query["RecoveryUseSsd"] = request.RecoveryUseSsd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForcedFailover",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForcedFailoverResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ForcedFailoverResponse ForcedFailover(ForcedFailoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForcedFailoverWithOptions(request, runtime);
        }

        public async Task<ForcedFailoverResponse> ForcedFailoverAsync(ForcedFailoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForcedFailoverWithOptionsAsync(request, runtime);
        }

        public RegisterServersResponse RegisterServersWithOptions(RegisterServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPort))
            {
                query["AgentPort"] = request.AgentPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerInstancesInfo))
            {
                query["ServerInstancesInfo"] = request.ServerInstancesInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterServers",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterServersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterServersResponse> RegisterServersWithOptionsAsync(RegisterServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentPort))
            {
                query["AgentPort"] = request.AgentPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerInstancesInfo))
            {
                query["ServerInstancesInfo"] = request.ServerInstancesInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SitePairId))
            {
                query["SitePairId"] = request.SitePairId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterServers",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterServersResponse RegisterServers(RegisterServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterServersWithOptions(request, runtime);
        }

        public async Task<RegisterServersResponse> RegisterServersAsync(RegisterServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterServersWithOptionsAsync(request, runtime);
        }

        public ReversedDisableReplicationResponse ReversedDisableReplicationWithOptions(ReversedDisableReplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReversedDisableReplication",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReversedDisableReplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReversedDisableReplicationResponse> ReversedDisableReplicationWithOptionsAsync(ReversedDisableReplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReversedDisableReplication",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReversedDisableReplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReversedDisableReplicationResponse ReversedDisableReplication(ReversedDisableReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReversedDisableReplicationWithOptions(request, runtime);
        }

        public async Task<ReversedDisableReplicationResponse> ReversedDisableReplicationAsync(ReversedDisableReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReversedDisableReplicationWithOptionsAsync(request, runtime);
        }

        public ReversedEnableReplicationResponse ReversedEnableReplicationWithOptions(ReversedEnableReplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppConsistentPointPolicy))
            {
                query["AppConsistentPointPolicy"] = request.AppConsistentPointPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrashConsistentPointPolicy))
            {
                query["CrashConsistentPointPolicy"] = request.CrashConsistentPointPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationComputeResource))
            {
                query["ReplicationComputeResource"] = request.ReplicationComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationDatastore))
            {
                query["ReplicationDatastore"] = request.ReplicationDatastore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationDns))
            {
                query["ReplicationDns"] = request.ReplicationDns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationGateway))
            {
                query["ReplicationGateway"] = request.ReplicationGateway;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationInfrastructureId))
            {
                query["ReplicationInfrastructureId"] = request.ReplicationInfrastructureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationIpAddress))
            {
                query["ReplicationIpAddress"] = request.ReplicationIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationLocation))
            {
                query["ReplicationLocation"] = request.ReplicationLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationNetMask))
            {
                query["ReplicationNetMask"] = request.ReplicationNetMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationNetwork))
            {
                query["ReplicationNetwork"] = request.ReplicationNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationUseDhcp))
            {
                query["ReplicationUseDhcp"] = request.ReplicationUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationUseOriginalInstance))
            {
                query["ReplicationUseOriginalInstance"] = request.ReplicationUseOriginalInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShadowInstanceType))
            {
                query["ShadowInstanceType"] = request.ShadowInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReversedEnableReplication",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReversedEnableReplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReversedEnableReplicationResponse> ReversedEnableReplicationWithOptionsAsync(ReversedEnableReplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppConsistentPointPolicy))
            {
                query["AppConsistentPointPolicy"] = request.AppConsistentPointPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrashConsistentPointPolicy))
            {
                query["CrashConsistentPointPolicy"] = request.CrashConsistentPointPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationComputeResource))
            {
                query["ReplicationComputeResource"] = request.ReplicationComputeResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationDatastore))
            {
                query["ReplicationDatastore"] = request.ReplicationDatastore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationDns))
            {
                query["ReplicationDns"] = request.ReplicationDns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationGateway))
            {
                query["ReplicationGateway"] = request.ReplicationGateway;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationInfrastructureId))
            {
                query["ReplicationInfrastructureId"] = request.ReplicationInfrastructureId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationIpAddress))
            {
                query["ReplicationIpAddress"] = request.ReplicationIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationLocation))
            {
                query["ReplicationLocation"] = request.ReplicationLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationNetMask))
            {
                query["ReplicationNetMask"] = request.ReplicationNetMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationNetwork))
            {
                query["ReplicationNetwork"] = request.ReplicationNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationUseDhcp))
            {
                query["ReplicationUseDhcp"] = request.ReplicationUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationUseOriginalInstance))
            {
                query["ReplicationUseOriginalInstance"] = request.ReplicationUseOriginalInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShadowInstanceType))
            {
                query["ShadowInstanceType"] = request.ShadowInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReversedEnableReplication",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReversedEnableReplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReversedEnableReplicationResponse ReversedEnableReplication(ReversedEnableReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReversedEnableReplicationWithOptions(request, runtime);
        }

        public async Task<ReversedEnableReplicationResponse> ReversedEnableReplicationAsync(ReversedEnableReplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReversedEnableReplicationWithOptionsAsync(request, runtime);
        }

        public TestCleanupResponse TestCleanupWithOptions(TestCleanupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestCleanup",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestCleanupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TestCleanupResponse> TestCleanupWithOptionsAsync(TestCleanupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestCleanup",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestCleanupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TestCleanupResponse TestCleanup(TestCleanupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestCleanupWithOptions(request, runtime);
        }

        public async Task<TestCleanupResponse> TestCleanupAsync(TestCleanupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestCleanupWithOptionsAsync(request, runtime);
        }

        public TestFailoverResponse TestFailoverWithOptions(TestFailoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipAddressId))
            {
                query["EipAddressId"] = request.EipAddressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryCpu))
            {
                query["RecoveryCpu"] = request.RecoveryCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryEssdPerformanceLevel))
            {
                query["RecoveryEssdPerformanceLevel"] = request.RecoveryEssdPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceName))
            {
                query["RecoveryInstanceName"] = request.RecoveryInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceType))
            {
                query["RecoveryInstanceType"] = request.RecoveryInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryIpAddress))
            {
                query["RecoveryIpAddress"] = request.RecoveryIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMemory))
            {
                query["RecoveryMemory"] = request.RecoveryMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointId))
            {
                query["RecoveryPointId"] = request.RecoveryPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointTime))
            {
                query["RecoveryPointTime"] = request.RecoveryPointTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptContent))
            {
                query["RecoveryPostScriptContent"] = request.RecoveryPostScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptType))
            {
                query["RecoveryPostScriptType"] = request.RecoveryPostScriptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryReserveIp))
            {
                query["RecoveryReserveIp"] = request.RecoveryReserveIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseDhcp))
            {
                query["RecoveryUseDhcp"] = request.RecoveryUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseEssd))
            {
                query["RecoveryUseEssd"] = request.RecoveryUseEssd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseSsd))
            {
                query["RecoveryUseSsd"] = request.RecoveryUseSsd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestFailover",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestFailoverResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TestFailoverResponse> TestFailoverWithOptionsAsync(TestFailoverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipAddressId))
            {
                query["EipAddressId"] = request.EipAddressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryCpu))
            {
                query["RecoveryCpu"] = request.RecoveryCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryEssdPerformanceLevel))
            {
                query["RecoveryEssdPerformanceLevel"] = request.RecoveryEssdPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceName))
            {
                query["RecoveryInstanceName"] = request.RecoveryInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryInstanceType))
            {
                query["RecoveryInstanceType"] = request.RecoveryInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryIpAddress))
            {
                query["RecoveryIpAddress"] = request.RecoveryIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryMemory))
            {
                query["RecoveryMemory"] = request.RecoveryMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryNetwork))
            {
                query["RecoveryNetwork"] = request.RecoveryNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointId))
            {
                query["RecoveryPointId"] = request.RecoveryPointId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointTime))
            {
                query["RecoveryPointTime"] = request.RecoveryPointTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptContent))
            {
                query["RecoveryPostScriptContent"] = request.RecoveryPostScriptContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPostScriptType))
            {
                query["RecoveryPostScriptType"] = request.RecoveryPostScriptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryReserveIp))
            {
                query["RecoveryReserveIp"] = request.RecoveryReserveIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseDhcp))
            {
                query["RecoveryUseDhcp"] = request.RecoveryUseDhcp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseEssd))
            {
                query["RecoveryUseEssd"] = request.RecoveryUseEssd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryUseSsd))
            {
                query["RecoveryUseSsd"] = request.RecoveryUseSsd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestFailover",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestFailoverResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TestFailoverResponse TestFailover(TestFailoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestFailoverWithOptions(request, runtime);
        }

        public async Task<TestFailoverResponse> TestFailoverAsync(TestFailoverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestFailoverWithOptionsAsync(request, runtime);
        }

        public TriggerReversedRegisterResponse TriggerReversedRegisterWithOptions(TriggerReversedRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerReversedRegister",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerReversedRegisterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TriggerReversedRegisterResponse> TriggerReversedRegisterWithOptionsAsync(TriggerReversedRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerReversedRegister",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerReversedRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TriggerReversedRegisterResponse TriggerReversedRegister(TriggerReversedRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerReversedRegisterWithOptions(request, runtime);
        }

        public async Task<TriggerReversedRegisterResponse> TriggerReversedRegisterAsync(TriggerReversedRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerReversedRegisterWithOptionsAsync(request, runtime);
        }

        public UnregisterServerResponse UnregisterServerWithOptions(UnregisterServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnregisterServer",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnregisterServerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnregisterServerResponse> UnregisterServerWithOptionsAsync(UnregisterServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                query["SecurityToken"] = request.SecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerId))
            {
                query["ServerId"] = request.ServerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnregisterServer",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnregisterServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnregisterServerResponse UnregisterServer(UnregisterServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnregisterServerWithOptions(request, runtime);
        }

        public async Task<UnregisterServerResponse> UnregisterServerAsync(UnregisterServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnregisterServerWithOptionsAsync(request, runtime);
        }

        public UpdateRecoveryPlanResponse UpdateRecoveryPlanWithOptions(UpdateRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecoveryPlan",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateRecoveryPlanResponse> UpdateRecoveryPlanWithOptionsAsync(UpdateRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRecoveryPlan",
                Version = "2017-09-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateRecoveryPlanResponse UpdateRecoveryPlan(UpdateRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<UpdateRecoveryPlanResponse> UpdateRecoveryPlanAsync(UpdateRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecoveryPlanWithOptionsAsync(request, runtime);
        }

    }
}
