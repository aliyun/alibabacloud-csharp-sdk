// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ExpressConnectRouter20230901.Models;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("expressconnectrouter", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @param request AttachExpressConnectRouterChildInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachExpressConnectRouterChildInstanceResponse
         */
        public AttachExpressConnectRouterChildInstanceResponse AttachExpressConnectRouterChildInstanceWithOptions(AttachExpressConnectRouterChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                body["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceOwnerId))
            {
                body["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                body["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                body["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachExpressConnectRouterChildInstance",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachExpressConnectRouterChildInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AttachExpressConnectRouterChildInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachExpressConnectRouterChildInstanceResponse
         */
        public async Task<AttachExpressConnectRouterChildInstanceResponse> AttachExpressConnectRouterChildInstanceWithOptionsAsync(AttachExpressConnectRouterChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                body["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceOwnerId))
            {
                body["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                body["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                body["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachExpressConnectRouterChildInstance",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachExpressConnectRouterChildInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AttachExpressConnectRouterChildInstanceRequest
         * @return AttachExpressConnectRouterChildInstanceResponse
         */
        public AttachExpressConnectRouterChildInstanceResponse AttachExpressConnectRouterChildInstance(AttachExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachExpressConnectRouterChildInstanceWithOptions(request, runtime);
        }

        /**
         * @param request AttachExpressConnectRouterChildInstanceRequest
         * @return AttachExpressConnectRouterChildInstanceResponse
         */
        public async Task<AttachExpressConnectRouterChildInstanceResponse> AttachExpressConnectRouterChildInstanceAsync(AttachExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachExpressConnectRouterChildInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckAddRegionToExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckAddRegionToExpressConnectRouterResponse
         */
        public CheckAddRegionToExpressConnectRouterResponse CheckAddRegionToExpressConnectRouterWithOptions(CheckAddRegionToExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreshRegionId))
            {
                body["FreshRegionId"] = request.FreshRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAddRegionToExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAddRegionToExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CheckAddRegionToExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckAddRegionToExpressConnectRouterResponse
         */
        public async Task<CheckAddRegionToExpressConnectRouterResponse> CheckAddRegionToExpressConnectRouterWithOptionsAsync(CheckAddRegionToExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreshRegionId))
            {
                body["FreshRegionId"] = request.FreshRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckAddRegionToExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckAddRegionToExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CheckAddRegionToExpressConnectRouterRequest
         * @return CheckAddRegionToExpressConnectRouterResponse
         */
        public CheckAddRegionToExpressConnectRouterResponse CheckAddRegionToExpressConnectRouter(CheckAddRegionToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAddRegionToExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request CheckAddRegionToExpressConnectRouterRequest
         * @return CheckAddRegionToExpressConnectRouterResponse
         */
        public async Task<CheckAddRegionToExpressConnectRouterResponse> CheckAddRegionToExpressConnectRouterAsync(CheckAddRegionToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAddRegionToExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExpressConnectRouterResponse
         */
        public CreateExpressConnectRouterResponse CreateExpressConnectRouterWithOptions(CreateExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlibabaSideAsn))
            {
                body["AlibabaSideAsn"] = request.AlibabaSideAsn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExpressConnectRouterResponse
         */
        public async Task<CreateExpressConnectRouterResponse> CreateExpressConnectRouterWithOptionsAsync(CreateExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlibabaSideAsn))
            {
                body["AlibabaSideAsn"] = request.AlibabaSideAsn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateExpressConnectRouterRequest
         * @return CreateExpressConnectRouterResponse
         */
        public CreateExpressConnectRouterResponse CreateExpressConnectRouter(CreateExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request CreateExpressConnectRouterRequest
         * @return CreateExpressConnectRouterResponse
         */
        public async Task<CreateExpressConnectRouterResponse> CreateExpressConnectRouterAsync(CreateExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateExpressConnectRouterAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExpressConnectRouterAssociationResponse
         */
        public CreateExpressConnectRouterAssociationResponse CreateExpressConnectRouterAssociationWithOptions(CreateExpressConnectRouterAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixes))
            {
                body["AllowedPrefixes"] = request.AllowedPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationRegionId))
            {
                body["AssociationRegionId"] = request.AssociationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                body["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateAttachment))
            {
                body["CreateAttachment"] = request.CreateAttachment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                body["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterOwnerId))
            {
                body["TransitRouterOwnerId"] = request.TransitRouterOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcOwnerId))
            {
                body["VpcOwnerId"] = request.VpcOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExpressConnectRouterAssociation",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExpressConnectRouterAssociationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateExpressConnectRouterAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExpressConnectRouterAssociationResponse
         */
        public async Task<CreateExpressConnectRouterAssociationResponse> CreateExpressConnectRouterAssociationWithOptionsAsync(CreateExpressConnectRouterAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixes))
            {
                body["AllowedPrefixes"] = request.AllowedPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationRegionId))
            {
                body["AssociationRegionId"] = request.AssociationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                body["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateAttachment))
            {
                body["CreateAttachment"] = request.CreateAttachment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                body["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterOwnerId))
            {
                body["TransitRouterOwnerId"] = request.TransitRouterOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcOwnerId))
            {
                body["VpcOwnerId"] = request.VpcOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExpressConnectRouterAssociation",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExpressConnectRouterAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateExpressConnectRouterAssociationRequest
         * @return CreateExpressConnectRouterAssociationResponse
         */
        public CreateExpressConnectRouterAssociationResponse CreateExpressConnectRouterAssociation(CreateExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExpressConnectRouterAssociationWithOptions(request, runtime);
        }

        /**
         * @param request CreateExpressConnectRouterAssociationRequest
         * @return CreateExpressConnectRouterAssociationResponse
         */
        public async Task<CreateExpressConnectRouterAssociationResponse> CreateExpressConnectRouterAssociationAsync(CreateExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExpressConnectRouterAssociationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExpressConnectRouterResponse
         */
        public DeleteExpressConnectRouterResponse DeleteExpressConnectRouterWithOptions(DeleteExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExpressConnectRouterResponse
         */
        public async Task<DeleteExpressConnectRouterResponse> DeleteExpressConnectRouterWithOptionsAsync(DeleteExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteExpressConnectRouterRequest
         * @return DeleteExpressConnectRouterResponse
         */
        public DeleteExpressConnectRouterResponse DeleteExpressConnectRouter(DeleteExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request DeleteExpressConnectRouterRequest
         * @return DeleteExpressConnectRouterResponse
         */
        public async Task<DeleteExpressConnectRouterResponse> DeleteExpressConnectRouterAsync(DeleteExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteExpressConnectRouterAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExpressConnectRouterAssociationResponse
         */
        public DeleteExpressConnectRouterAssociationResponse DeleteExpressConnectRouterAssociationWithOptions(DeleteExpressConnectRouterAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAttachment))
            {
                body["DeleteAttachment"] = request.DeleteAttachment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExpressConnectRouterAssociation",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExpressConnectRouterAssociationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteExpressConnectRouterAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExpressConnectRouterAssociationResponse
         */
        public async Task<DeleteExpressConnectRouterAssociationResponse> DeleteExpressConnectRouterAssociationWithOptionsAsync(DeleteExpressConnectRouterAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAttachment))
            {
                body["DeleteAttachment"] = request.DeleteAttachment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExpressConnectRouterAssociation",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExpressConnectRouterAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteExpressConnectRouterAssociationRequest
         * @return DeleteExpressConnectRouterAssociationResponse
         */
        public DeleteExpressConnectRouterAssociationResponse DeleteExpressConnectRouterAssociation(DeleteExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExpressConnectRouterAssociationWithOptions(request, runtime);
        }

        /**
         * @param request DeleteExpressConnectRouterAssociationRequest
         * @return DeleteExpressConnectRouterAssociationResponse
         */
        public async Task<DeleteExpressConnectRouterAssociationResponse> DeleteExpressConnectRouterAssociationAsync(DeleteExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExpressConnectRouterAssociationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDisabledExpressConnectRouterRouteEntriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDisabledExpressConnectRouterRouteEntriesResponse
         */
        public DescribeDisabledExpressConnectRouterRouteEntriesResponse DescribeDisabledExpressConnectRouterRouteEntriesWithOptions(DescribeDisabledExpressConnectRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisabledExpressConnectRouterRouteEntries",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisabledExpressConnectRouterRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDisabledExpressConnectRouterRouteEntriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDisabledExpressConnectRouterRouteEntriesResponse
         */
        public async Task<DescribeDisabledExpressConnectRouterRouteEntriesResponse> DescribeDisabledExpressConnectRouterRouteEntriesWithOptionsAsync(DescribeDisabledExpressConnectRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDisabledExpressConnectRouterRouteEntries",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDisabledExpressConnectRouterRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDisabledExpressConnectRouterRouteEntriesRequest
         * @return DescribeDisabledExpressConnectRouterRouteEntriesResponse
         */
        public DescribeDisabledExpressConnectRouterRouteEntriesResponse DescribeDisabledExpressConnectRouterRouteEntries(DescribeDisabledExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisabledExpressConnectRouterRouteEntriesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDisabledExpressConnectRouterRouteEntriesRequest
         * @return DescribeDisabledExpressConnectRouterRouteEntriesResponse
         */
        public async Task<DescribeDisabledExpressConnectRouterRouteEntriesResponse> DescribeDisabledExpressConnectRouterRouteEntriesAsync(DescribeDisabledExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisabledExpressConnectRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterResponse
         */
        public DescribeExpressConnectRouterResponse DescribeExpressConnectRouterWithOptions(DescribeExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagModels))
            {
                body["TagModels"] = request.TagModels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterResponse
         */
        public async Task<DescribeExpressConnectRouterResponse> DescribeExpressConnectRouterWithOptionsAsync(DescribeExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagModels))
            {
                body["TagModels"] = request.TagModels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterRequest
         * @return DescribeExpressConnectRouterResponse
         */
        public DescribeExpressConnectRouterResponse DescribeExpressConnectRouter(DescribeExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterRequest
         * @return DescribeExpressConnectRouterResponse
         */
        public async Task<DescribeExpressConnectRouterResponse> DescribeExpressConnectRouterAsync(DescribeExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterAllowedPrefixHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterAllowedPrefixHistoryResponse
         */
        public DescribeExpressConnectRouterAllowedPrefixHistoryResponse DescribeExpressConnectRouterAllowedPrefixHistoryWithOptions(DescribeExpressConnectRouterAllowedPrefixHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterAllowedPrefixHistory",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterAllowedPrefixHistoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterAllowedPrefixHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterAllowedPrefixHistoryResponse
         */
        public async Task<DescribeExpressConnectRouterAllowedPrefixHistoryResponse> DescribeExpressConnectRouterAllowedPrefixHistoryWithOptionsAsync(DescribeExpressConnectRouterAllowedPrefixHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterAllowedPrefixHistory",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterAllowedPrefixHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterAllowedPrefixHistoryRequest
         * @return DescribeExpressConnectRouterAllowedPrefixHistoryResponse
         */
        public DescribeExpressConnectRouterAllowedPrefixHistoryResponse DescribeExpressConnectRouterAllowedPrefixHistory(DescribeExpressConnectRouterAllowedPrefixHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterAllowedPrefixHistoryWithOptions(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterAllowedPrefixHistoryRequest
         * @return DescribeExpressConnectRouterAllowedPrefixHistoryResponse
         */
        public async Task<DescribeExpressConnectRouterAllowedPrefixHistoryResponse> DescribeExpressConnectRouterAllowedPrefixHistoryAsync(DescribeExpressConnectRouterAllowedPrefixHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterAllowedPrefixHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterAssociationResponse
         */
        public DescribeExpressConnectRouterAssociationResponse DescribeExpressConnectRouterAssociationWithOptions(DescribeExpressConnectRouterAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationNodeType))
            {
                body["AssociationNodeType"] = request.AssociationNodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationRegionId))
            {
                body["AssociationRegionId"] = request.AssociationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                body["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                body["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterAssociation",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterAssociationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterAssociationResponse
         */
        public async Task<DescribeExpressConnectRouterAssociationResponse> DescribeExpressConnectRouterAssociationWithOptionsAsync(DescribeExpressConnectRouterAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationNodeType))
            {
                body["AssociationNodeType"] = request.AssociationNodeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationRegionId))
            {
                body["AssociationRegionId"] = request.AssociationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                body["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                body["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterAssociation",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterAssociationRequest
         * @return DescribeExpressConnectRouterAssociationResponse
         */
        public DescribeExpressConnectRouterAssociationResponse DescribeExpressConnectRouterAssociation(DescribeExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterAssociationWithOptions(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterAssociationRequest
         * @return DescribeExpressConnectRouterAssociationResponse
         */
        public async Task<DescribeExpressConnectRouterAssociationResponse> DescribeExpressConnectRouterAssociationAsync(DescribeExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterAssociationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterChildInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterChildInstanceResponse
         */
        public DescribeExpressConnectRouterChildInstanceResponse DescribeExpressConnectRouterChildInstanceWithOptions(DescribeExpressConnectRouterChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                body["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                body["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                body["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterChildInstance",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterChildInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterChildInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterChildInstanceResponse
         */
        public async Task<DescribeExpressConnectRouterChildInstanceResponse> DescribeExpressConnectRouterChildInstanceWithOptionsAsync(DescribeExpressConnectRouterChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                body["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                body["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                body["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterChildInstance",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterChildInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterChildInstanceRequest
         * @return DescribeExpressConnectRouterChildInstanceResponse
         */
        public DescribeExpressConnectRouterChildInstanceResponse DescribeExpressConnectRouterChildInstance(DescribeExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterChildInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterChildInstanceRequest
         * @return DescribeExpressConnectRouterChildInstanceResponse
         */
        public async Task<DescribeExpressConnectRouterChildInstanceResponse> DescribeExpressConnectRouterChildInstanceAsync(DescribeExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterChildInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterInterRegionTransitModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterInterRegionTransitModeResponse
         */
        public DescribeExpressConnectRouterInterRegionTransitModeResponse DescribeExpressConnectRouterInterRegionTransitModeWithOptions(DescribeExpressConnectRouterInterRegionTransitModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterInterRegionTransitMode",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterInterRegionTransitModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterInterRegionTransitModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterInterRegionTransitModeResponse
         */
        public async Task<DescribeExpressConnectRouterInterRegionTransitModeResponse> DescribeExpressConnectRouterInterRegionTransitModeWithOptionsAsync(DescribeExpressConnectRouterInterRegionTransitModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterInterRegionTransitMode",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterInterRegionTransitModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterInterRegionTransitModeRequest
         * @return DescribeExpressConnectRouterInterRegionTransitModeResponse
         */
        public DescribeExpressConnectRouterInterRegionTransitModeResponse DescribeExpressConnectRouterInterRegionTransitMode(DescribeExpressConnectRouterInterRegionTransitModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterInterRegionTransitModeWithOptions(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterInterRegionTransitModeRequest
         * @return DescribeExpressConnectRouterInterRegionTransitModeResponse
         */
        public async Task<DescribeExpressConnectRouterInterRegionTransitModeResponse> DescribeExpressConnectRouterInterRegionTransitModeAsync(DescribeExpressConnectRouterInterRegionTransitModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterInterRegionTransitModeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterRegionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterRegionResponse
         */
        public DescribeExpressConnectRouterRegionResponse DescribeExpressConnectRouterRegionWithOptions(DescribeExpressConnectRouterRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterRegion",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterRegionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterRegionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterRegionResponse
         */
        public async Task<DescribeExpressConnectRouterRegionResponse> DescribeExpressConnectRouterRegionWithOptionsAsync(DescribeExpressConnectRouterRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterRegion",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterRegionRequest
         * @return DescribeExpressConnectRouterRegionResponse
         */
        public DescribeExpressConnectRouterRegionResponse DescribeExpressConnectRouterRegion(DescribeExpressConnectRouterRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterRegionWithOptions(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterRegionRequest
         * @return DescribeExpressConnectRouterRegionResponse
         */
        public async Task<DescribeExpressConnectRouterRegionResponse> DescribeExpressConnectRouterRegionAsync(DescribeExpressConnectRouterRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterRegionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterRouteEntriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterRouteEntriesResponse
         */
        public DescribeExpressConnectRouterRouteEntriesResponse DescribeExpressConnectRouterRouteEntriesWithOptions(DescribeExpressConnectRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsPath))
            {
                body["AsPath"] = request.AsPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Community))
            {
                body["Community"] = request.Community;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NexthopInstanceId))
            {
                body["NexthopInstanceId"] = request.NexthopInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRegionId))
            {
                body["QueryRegionId"] = request.QueryRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterRouteEntries",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterRouteEntriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExpressConnectRouterRouteEntriesResponse
         */
        public async Task<DescribeExpressConnectRouterRouteEntriesResponse> DescribeExpressConnectRouterRouteEntriesWithOptionsAsync(DescribeExpressConnectRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsPath))
            {
                body["AsPath"] = request.AsPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Community))
            {
                body["Community"] = request.Community;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NexthopInstanceId))
            {
                body["NexthopInstanceId"] = request.NexthopInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRegionId))
            {
                body["QueryRegionId"] = request.QueryRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExpressConnectRouterRouteEntries",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExpressConnectRouterRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeExpressConnectRouterRouteEntriesRequest
         * @return DescribeExpressConnectRouterRouteEntriesResponse
         */
        public DescribeExpressConnectRouterRouteEntriesResponse DescribeExpressConnectRouterRouteEntries(DescribeExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterRouteEntriesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeExpressConnectRouterRouteEntriesRequest
         * @return DescribeExpressConnectRouterRouteEntriesResponse
         */
        public async Task<DescribeExpressConnectRouterRouteEntriesResponse> DescribeExpressConnectRouterRouteEntriesAsync(DescribeExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInstanceGrantedToExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceGrantedToExpressConnectRouterResponse
         */
        public DescribeInstanceGrantedToExpressConnectRouterResponse DescribeInstanceGrantedToExpressConnectRouterWithOptions(DescribeInstanceGrantedToExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                body["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                body["InstanceRegionId"] = request.InstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagModels))
            {
                body["TagModels"] = request.TagModels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceGrantedToExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceGrantedToExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceGrantedToExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceGrantedToExpressConnectRouterResponse
         */
        public async Task<DescribeInstanceGrantedToExpressConnectRouterResponse> DescribeInstanceGrantedToExpressConnectRouterWithOptionsAsync(DescribeInstanceGrantedToExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceOwnerId))
            {
                body["InstanceOwnerId"] = request.InstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                body["InstanceRegionId"] = request.InstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagModels))
            {
                body["TagModels"] = request.TagModels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceGrantedToExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceGrantedToExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInstanceGrantedToExpressConnectRouterRequest
         * @return DescribeInstanceGrantedToExpressConnectRouterResponse
         */
        public DescribeInstanceGrantedToExpressConnectRouterResponse DescribeInstanceGrantedToExpressConnectRouter(DescribeInstanceGrantedToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceGrantedToExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInstanceGrantedToExpressConnectRouterRequest
         * @return DescribeInstanceGrantedToExpressConnectRouterResponse
         */
        public async Task<DescribeInstanceGrantedToExpressConnectRouterResponse> DescribeInstanceGrantedToExpressConnectRouterAsync(DescribeInstanceGrantedToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceGrantedToExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DetachExpressConnectRouterChildInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachExpressConnectRouterChildInstanceResponse
         */
        public DetachExpressConnectRouterChildInstanceResponse DetachExpressConnectRouterChildInstanceWithOptions(DetachExpressConnectRouterChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                body["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                body["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachExpressConnectRouterChildInstance",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachExpressConnectRouterChildInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DetachExpressConnectRouterChildInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachExpressConnectRouterChildInstanceResponse
         */
        public async Task<DetachExpressConnectRouterChildInstanceResponse> DetachExpressConnectRouterChildInstanceWithOptionsAsync(DetachExpressConnectRouterChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                body["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                body["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachExpressConnectRouterChildInstance",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachExpressConnectRouterChildInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DetachExpressConnectRouterChildInstanceRequest
         * @return DetachExpressConnectRouterChildInstanceResponse
         */
        public DetachExpressConnectRouterChildInstanceResponse DetachExpressConnectRouterChildInstance(DetachExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachExpressConnectRouterChildInstanceWithOptions(request, runtime);
        }

        /**
         * @param request DetachExpressConnectRouterChildInstanceRequest
         * @return DetachExpressConnectRouterChildInstanceResponse
         */
        public async Task<DetachExpressConnectRouterChildInstanceResponse> DetachExpressConnectRouterChildInstanceAsync(DetachExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachExpressConnectRouterChildInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DisableExpressConnectRouterRouteEntriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableExpressConnectRouterRouteEntriesResponse
         */
        public DisableExpressConnectRouterRouteEntriesResponse DisableExpressConnectRouterRouteEntriesWithOptions(DisableExpressConnectRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NexthopInstanceId))
            {
                body["NexthopInstanceId"] = request.NexthopInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableExpressConnectRouterRouteEntries",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableExpressConnectRouterRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DisableExpressConnectRouterRouteEntriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableExpressConnectRouterRouteEntriesResponse
         */
        public async Task<DisableExpressConnectRouterRouteEntriesResponse> DisableExpressConnectRouterRouteEntriesWithOptionsAsync(DisableExpressConnectRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NexthopInstanceId))
            {
                body["NexthopInstanceId"] = request.NexthopInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableExpressConnectRouterRouteEntries",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableExpressConnectRouterRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DisableExpressConnectRouterRouteEntriesRequest
         * @return DisableExpressConnectRouterRouteEntriesResponse
         */
        public DisableExpressConnectRouterRouteEntriesResponse DisableExpressConnectRouterRouteEntries(DisableExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableExpressConnectRouterRouteEntriesWithOptions(request, runtime);
        }

        /**
         * @param request DisableExpressConnectRouterRouteEntriesRequest
         * @return DisableExpressConnectRouterRouteEntriesResponse
         */
        public async Task<DisableExpressConnectRouterRouteEntriesResponse> DisableExpressConnectRouterRouteEntriesAsync(DisableExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableExpressConnectRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EnableExpressConnectRouterRouteEntriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableExpressConnectRouterRouteEntriesResponse
         */
        public EnableExpressConnectRouterRouteEntriesResponse EnableExpressConnectRouterRouteEntriesWithOptions(EnableExpressConnectRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NexthopInstanceId))
            {
                body["NexthopInstanceId"] = request.NexthopInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableExpressConnectRouterRouteEntries",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableExpressConnectRouterRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request EnableExpressConnectRouterRouteEntriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableExpressConnectRouterRouteEntriesResponse
         */
        public async Task<EnableExpressConnectRouterRouteEntriesResponse> EnableExpressConnectRouterRouteEntriesWithOptionsAsync(EnableExpressConnectRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                body["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NexthopInstanceId))
            {
                body["NexthopInstanceId"] = request.NexthopInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableExpressConnectRouterRouteEntries",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableExpressConnectRouterRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request EnableExpressConnectRouterRouteEntriesRequest
         * @return EnableExpressConnectRouterRouteEntriesResponse
         */
        public EnableExpressConnectRouterRouteEntriesResponse EnableExpressConnectRouterRouteEntries(EnableExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableExpressConnectRouterRouteEntriesWithOptions(request, runtime);
        }

        /**
         * @param request EnableExpressConnectRouterRouteEntriesRequest
         * @return EnableExpressConnectRouterRouteEntriesResponse
         */
        public async Task<EnableExpressConnectRouterRouteEntriesResponse> EnableExpressConnectRouterRouteEntriesAsync(EnableExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableExpressConnectRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ForceDeleteExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ForceDeleteExpressConnectRouterResponse
         */
        public ForceDeleteExpressConnectRouterResponse ForceDeleteExpressConnectRouterWithOptions(ForceDeleteExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForceDeleteExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForceDeleteExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ForceDeleteExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ForceDeleteExpressConnectRouterResponse
         */
        public async Task<ForceDeleteExpressConnectRouterResponse> ForceDeleteExpressConnectRouterWithOptionsAsync(ForceDeleteExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ForceDeleteExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ForceDeleteExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ForceDeleteExpressConnectRouterRequest
         * @return ForceDeleteExpressConnectRouterResponse
         */
        public ForceDeleteExpressConnectRouterResponse ForceDeleteExpressConnectRouter(ForceDeleteExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForceDeleteExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request ForceDeleteExpressConnectRouterRequest
         * @return ForceDeleteExpressConnectRouterResponse
         */
        public async Task<ForceDeleteExpressConnectRouterResponse> ForceDeleteExpressConnectRouterAsync(ForceDeleteExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForceDeleteExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GrantInstanceToExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantInstanceToExpressConnectRouterResponse
         */
        public GrantInstanceToExpressConnectRouterResponse GrantInstanceToExpressConnectRouterWithOptions(GrantInstanceToExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrOwnerAliUid))
            {
                body["EcrOwnerAliUid"] = request.EcrOwnerAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                body["InstanceRegionId"] = request.InstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantInstanceToExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantInstanceToExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GrantInstanceToExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantInstanceToExpressConnectRouterResponse
         */
        public async Task<GrantInstanceToExpressConnectRouterResponse> GrantInstanceToExpressConnectRouterWithOptionsAsync(GrantInstanceToExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrOwnerAliUid))
            {
                body["EcrOwnerAliUid"] = request.EcrOwnerAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                body["InstanceRegionId"] = request.InstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantInstanceToExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantInstanceToExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GrantInstanceToExpressConnectRouterRequest
         * @return GrantInstanceToExpressConnectRouterResponse
         */
        public GrantInstanceToExpressConnectRouterResponse GrantInstanceToExpressConnectRouter(GrantInstanceToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantInstanceToExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request GrantInstanceToExpressConnectRouterRequest
         * @return GrantInstanceToExpressConnectRouterResponse
         */
        public async Task<GrantInstanceToExpressConnectRouterResponse> GrantInstanceToExpressConnectRouterAsync(GrantInstanceToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantInstanceToExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListExpressConnectRouterSupportedRegionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExpressConnectRouterSupportedRegionResponse
         */
        public ListExpressConnectRouterSupportedRegionResponse ListExpressConnectRouterSupportedRegionWithOptions(ListExpressConnectRouterSupportedRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                body["NodeType"] = request.NodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExpressConnectRouterSupportedRegion",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExpressConnectRouterSupportedRegionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListExpressConnectRouterSupportedRegionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExpressConnectRouterSupportedRegionResponse
         */
        public async Task<ListExpressConnectRouterSupportedRegionResponse> ListExpressConnectRouterSupportedRegionWithOptionsAsync(ListExpressConnectRouterSupportedRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeType))
            {
                body["NodeType"] = request.NodeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExpressConnectRouterSupportedRegion",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExpressConnectRouterSupportedRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListExpressConnectRouterSupportedRegionRequest
         * @return ListExpressConnectRouterSupportedRegionResponse
         */
        public ListExpressConnectRouterSupportedRegionResponse ListExpressConnectRouterSupportedRegion(ListExpressConnectRouterSupportedRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExpressConnectRouterSupportedRegionWithOptions(request, runtime);
        }

        /**
         * @param request ListExpressConnectRouterSupportedRegionRequest
         * @return ListExpressConnectRouterSupportedRegionResponse
         */
        public async Task<ListExpressConnectRouterSupportedRegionResponse> ListExpressConnectRouterSupportedRegionAsync(ListExpressConnectRouterSupportedRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExpressConnectRouterSupportedRegionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyExpressConnectRouterResponse
         */
        public ModifyExpressConnectRouterResponse ModifyExpressConnectRouterWithOptions(ModifyExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyExpressConnectRouterResponse
         */
        public async Task<ModifyExpressConnectRouterResponse> ModifyExpressConnectRouterWithOptionsAsync(ModifyExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyExpressConnectRouterRequest
         * @return ModifyExpressConnectRouterResponse
         */
        public ModifyExpressConnectRouterResponse ModifyExpressConnectRouter(ModifyExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request ModifyExpressConnectRouterRequest
         * @return ModifyExpressConnectRouterResponse
         */
        public async Task<ModifyExpressConnectRouterResponse> ModifyExpressConnectRouterAsync(ModifyExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyExpressConnectRouterAssociationAllowedPrefixRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyExpressConnectRouterAssociationAllowedPrefixResponse
         */
        public ModifyExpressConnectRouterAssociationAllowedPrefixResponse ModifyExpressConnectRouterAssociationAllowedPrefixWithOptions(ModifyExpressConnectRouterAssociationAllowedPrefixRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixes))
            {
                body["AllowedPrefixes"] = request.AllowedPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                body["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyExpressConnectRouterAssociationAllowedPrefix",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyExpressConnectRouterAssociationAllowedPrefixResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyExpressConnectRouterAssociationAllowedPrefixRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyExpressConnectRouterAssociationAllowedPrefixResponse
         */
        public async Task<ModifyExpressConnectRouterAssociationAllowedPrefixResponse> ModifyExpressConnectRouterAssociationAllowedPrefixWithOptionsAsync(ModifyExpressConnectRouterAssociationAllowedPrefixRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixes))
            {
                body["AllowedPrefixes"] = request.AllowedPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationId))
            {
                body["AssociationId"] = request.AssociationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                body["OwnerAccount"] = request.OwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyExpressConnectRouterAssociationAllowedPrefix",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyExpressConnectRouterAssociationAllowedPrefixResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyExpressConnectRouterAssociationAllowedPrefixRequest
         * @return ModifyExpressConnectRouterAssociationAllowedPrefixResponse
         */
        public ModifyExpressConnectRouterAssociationAllowedPrefixResponse ModifyExpressConnectRouterAssociationAllowedPrefix(ModifyExpressConnectRouterAssociationAllowedPrefixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExpressConnectRouterAssociationAllowedPrefixWithOptions(request, runtime);
        }

        /**
         * @param request ModifyExpressConnectRouterAssociationAllowedPrefixRequest
         * @return ModifyExpressConnectRouterAssociationAllowedPrefixResponse
         */
        public async Task<ModifyExpressConnectRouterAssociationAllowedPrefixResponse> ModifyExpressConnectRouterAssociationAllowedPrefixAsync(ModifyExpressConnectRouterAssociationAllowedPrefixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExpressConnectRouterAssociationAllowedPrefixWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ModifyExpressConnectRouterInterRegionTransitModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyExpressConnectRouterInterRegionTransitModeResponse
         */
        public ModifyExpressConnectRouterInterRegionTransitModeResponse ModifyExpressConnectRouterInterRegionTransitModeWithOptions(ModifyExpressConnectRouterInterRegionTransitModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitModeList))
            {
                body["TransitModeList"] = request.TransitModeList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyExpressConnectRouterInterRegionTransitMode",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyExpressConnectRouterInterRegionTransitModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ModifyExpressConnectRouterInterRegionTransitModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyExpressConnectRouterInterRegionTransitModeResponse
         */
        public async Task<ModifyExpressConnectRouterInterRegionTransitModeResponse> ModifyExpressConnectRouterInterRegionTransitModeWithOptionsAsync(ModifyExpressConnectRouterInterRegionTransitModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitModeList))
            {
                body["TransitModeList"] = request.TransitModeList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyExpressConnectRouterInterRegionTransitMode",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyExpressConnectRouterInterRegionTransitModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ModifyExpressConnectRouterInterRegionTransitModeRequest
         * @return ModifyExpressConnectRouterInterRegionTransitModeResponse
         */
        public ModifyExpressConnectRouterInterRegionTransitModeResponse ModifyExpressConnectRouterInterRegionTransitMode(ModifyExpressConnectRouterInterRegionTransitModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExpressConnectRouterInterRegionTransitModeWithOptions(request, runtime);
        }

        /**
         * @param request ModifyExpressConnectRouterInterRegionTransitModeRequest
         * @return ModifyExpressConnectRouterInterRegionTransitModeResponse
         */
        public async Task<ModifyExpressConnectRouterInterRegionTransitModeResponse> ModifyExpressConnectRouterInterRegionTransitModeAsync(ModifyExpressConnectRouterInterRegionTransitModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExpressConnectRouterInterRegionTransitModeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RevokeInstanceFromExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeInstanceFromExpressConnectRouterResponse
         */
        public RevokeInstanceFromExpressConnectRouterResponse RevokeInstanceFromExpressConnectRouterWithOptions(RevokeInstanceFromExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrOwnerAliUid))
            {
                body["EcrOwnerAliUid"] = request.EcrOwnerAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                body["InstanceRegionId"] = request.InstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeInstanceFromExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeInstanceFromExpressConnectRouterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RevokeInstanceFromExpressConnectRouterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeInstanceFromExpressConnectRouterResponse
         */
        public async Task<RevokeInstanceFromExpressConnectRouterResponse> RevokeInstanceFromExpressConnectRouterWithOptionsAsync(RevokeInstanceFromExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrOwnerAliUid))
            {
                body["EcrOwnerAliUid"] = request.EcrOwnerAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceRegionId))
            {
                body["InstanceRegionId"] = request.InstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeInstanceFromExpressConnectRouter",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeInstanceFromExpressConnectRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RevokeInstanceFromExpressConnectRouterRequest
         * @return RevokeInstanceFromExpressConnectRouterResponse
         */
        public RevokeInstanceFromExpressConnectRouterResponse RevokeInstanceFromExpressConnectRouter(RevokeInstanceFromExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeInstanceFromExpressConnectRouterWithOptions(request, runtime);
        }

        /**
         * @param request RevokeInstanceFromExpressConnectRouterRequest
         * @return RevokeInstanceFromExpressConnectRouterResponse
         */
        public async Task<RevokeInstanceFromExpressConnectRouterResponse> RevokeInstanceFromExpressConnectRouterAsync(RevokeInstanceFromExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeInstanceFromExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SynchronizeExpressConnectRouterInterRegionBandwidthRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SynchronizeExpressConnectRouterInterRegionBandwidthResponse
         */
        public SynchronizeExpressConnectRouterInterRegionBandwidthResponse SynchronizeExpressConnectRouterInterRegionBandwidthWithOptions(SynchronizeExpressConnectRouterInterRegionBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SynchronizeExpressConnectRouterInterRegionBandwidth",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SynchronizeExpressConnectRouterInterRegionBandwidthResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SynchronizeExpressConnectRouterInterRegionBandwidthRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SynchronizeExpressConnectRouterInterRegionBandwidthResponse
         */
        public async Task<SynchronizeExpressConnectRouterInterRegionBandwidthResponse> SynchronizeExpressConnectRouterInterRegionBandwidthWithOptionsAsync(SynchronizeExpressConnectRouterInterRegionBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcrId))
            {
                body["EcrId"] = request.EcrId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SynchronizeExpressConnectRouterInterRegionBandwidth",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SynchronizeExpressConnectRouterInterRegionBandwidthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SynchronizeExpressConnectRouterInterRegionBandwidthRequest
         * @return SynchronizeExpressConnectRouterInterRegionBandwidthResponse
         */
        public SynchronizeExpressConnectRouterInterRegionBandwidthResponse SynchronizeExpressConnectRouterInterRegionBandwidth(SynchronizeExpressConnectRouterInterRegionBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SynchronizeExpressConnectRouterInterRegionBandwidthWithOptions(request, runtime);
        }

        /**
         * @param request SynchronizeExpressConnectRouterInterRegionBandwidthRequest
         * @return SynchronizeExpressConnectRouterInterRegionBandwidthResponse
         */
        public async Task<SynchronizeExpressConnectRouterInterRegionBandwidthResponse> SynchronizeExpressConnectRouterInterRegionBandwidthAsync(SynchronizeExpressConnectRouterInterRegionBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SynchronizeExpressConnectRouterInterRegionBandwidthWithOptionsAsync(request, runtime);
        }

    }
}
