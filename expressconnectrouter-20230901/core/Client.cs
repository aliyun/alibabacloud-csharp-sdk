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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables log delivery for flow logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateFlowLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateFlowLogResponse
        /// </returns>
        public ActivateFlowLogResponse ActivateFlowLogWithOptions(ActivateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                body["FlowLogId"] = request.FlowLogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateFlowLog",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateFlowLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables log delivery for flow logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateFlowLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateFlowLogResponse
        /// </returns>
        public async Task<ActivateFlowLogResponse> ActivateFlowLogWithOptionsAsync(ActivateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                body["FlowLogId"] = request.FlowLogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateFlowLog",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateFlowLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables log delivery for flow logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateFlowLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateFlowLogResponse
        /// </returns>
        public ActivateFlowLogResponse ActivateFlowLog(ActivateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateFlowLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables log delivery for flow logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ActivateFlowLogRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateFlowLogResponse
        /// </returns>
        public async Task<ActivateFlowLogResponse> ActivateFlowLogAsync(ActivateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateFlowLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual border router (VBR) with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the <b>AttachExpressConnectRouterChildInstance</b> operation to associate a VBR with an ECR, make sure that the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachExpressConnectRouterChildInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachExpressConnectRouterChildInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual border router (VBR) with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the <b>AttachExpressConnectRouterChildInstance</b> operation to associate a VBR with an ECR, make sure that the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachExpressConnectRouterChildInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachExpressConnectRouterChildInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual border router (VBR) with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the <b>AttachExpressConnectRouterChildInstance</b> operation to associate a VBR with an ECR, make sure that the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachExpressConnectRouterChildInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachExpressConnectRouterChildInstanceResponse
        /// </returns>
        public AttachExpressConnectRouterChildInstanceResponse AttachExpressConnectRouterChildInstance(AttachExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachExpressConnectRouterChildInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual border router (VBR) with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the <b>AttachExpressConnectRouterChildInstance</b> operation to associate a VBR with an ECR, make sure that the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachExpressConnectRouterChildInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachExpressConnectRouterChildInstanceResponse
        /// </returns>
        public async Task<AttachExpressConnectRouterChildInstanceResponse> AttachExpressConnectRouterChildInstanceAsync(AttachExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachExpressConnectRouterChildInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the Cloud Data Transfer (CDT) service required to add a region to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAddRegionToExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAddRegionToExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the Cloud Data Transfer (CDT) service required to add a region to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAddRegionToExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckAddRegionToExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the Cloud Data Transfer (CDT) service required to add a region to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAddRegionToExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAddRegionToExpressConnectRouterResponse
        /// </returns>
        public CheckAddRegionToExpressConnectRouterResponse CheckAddRegionToExpressConnectRouter(CheckAddRegionToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckAddRegionToExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the Cloud Data Transfer (CDT) service required to add a region to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckAddRegionToExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckAddRegionToExpressConnectRouterResponse
        /// </returns>
        public async Task<CheckAddRegionToExpressConnectRouterResponse> CheckAddRegionToExpressConnectRouterAsync(CheckAddRegionToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckAddRegionToExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Express Connect Router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create an ECR, it enters the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExpressConnectRouterResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Express Connect Router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create an ECR, it enters the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExpressConnectRouterResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Express Connect Router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create an ECR, it enters the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExpressConnectRouterResponse
        /// </returns>
        public CreateExpressConnectRouterResponse CreateExpressConnectRouter(CreateExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Express Connect Router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create an ECR, it enters the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExpressConnectRouterResponse
        /// </returns>
        public async Task<CreateExpressConnectRouterResponse> CreateExpressConnectRouterAsync(CreateExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual private cloud (VPC) or a transit router (TR) with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExpressConnectRouterAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExpressConnectRouterAssociationResponse
        /// </returns>
        public CreateExpressConnectRouterAssociationResponse CreateExpressConnectRouterAssociationWithOptions(CreateExpressConnectRouterAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixes))
            {
                body["AllowedPrefixes"] = request.AllowedPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixesMode))
            {
                body["AllowedPrefixesMode"] = request.AllowedPrefixesMode;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual private cloud (VPC) or a transit router (TR) with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExpressConnectRouterAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExpressConnectRouterAssociationResponse
        /// </returns>
        public async Task<CreateExpressConnectRouterAssociationResponse> CreateExpressConnectRouterAssociationWithOptionsAsync(CreateExpressConnectRouterAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixes))
            {
                body["AllowedPrefixes"] = request.AllowedPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixesMode))
            {
                body["AllowedPrefixesMode"] = request.AllowedPrefixesMode;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual private cloud (VPC) or a transit router (TR) with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExpressConnectRouterAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExpressConnectRouterAssociationResponse
        /// </returns>
        public CreateExpressConnectRouterAssociationResponse CreateExpressConnectRouterAssociation(CreateExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExpressConnectRouterAssociationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates a virtual private cloud (VPC) or a transit router (TR) with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExpressConnectRouterAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExpressConnectRouterAssociationResponse
        /// </returns>
        public async Task<CreateExpressConnectRouterAssociationResponse> CreateExpressConnectRouterAssociationAsync(CreateExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExpressConnectRouterAssociationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow log and enables log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowLogResponse
        /// </returns>
        public CreateFlowLogResponse CreateFlowLogWithOptions(CreateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                query["SamplingRate"] = request.SamplingRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                body["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowLog",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow log and enables log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowLogResponse
        /// </returns>
        public async Task<CreateFlowLogResponse> CreateFlowLogWithOptionsAsync(CreateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                query["SamplingRate"] = request.SamplingRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                body["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowLog",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow log and enables log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowLogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowLogResponse
        /// </returns>
        public CreateFlowLogResponse CreateFlowLog(CreateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a flow log and enables log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFlowLogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFlowLogResponse
        /// </returns>
        public async Task<CreateFlowLogResponse> CreateFlowLogAsync(CreateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeactivateFlowLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeactivateFlowLogResponse
        /// </returns>
        public DeactivateFlowLogResponse DeactivateFlowLogWithOptions(DeactivateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                body["FlowLogId"] = request.FlowLogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeactivateFlowLog",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactivateFlowLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeactivateFlowLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeactivateFlowLogResponse
        /// </returns>
        public async Task<DeactivateFlowLogResponse> DeactivateFlowLogWithOptionsAsync(DeactivateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                body["FlowLogId"] = request.FlowLogId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeactivateFlowLog",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactivateFlowLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeactivateFlowLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DeactivateFlowLogResponse
        /// </returns>
        public DeactivateFlowLogResponse DeactivateFlowLog(DeactivateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactivateFlowLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables log delivery.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeactivateFlowLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DeactivateFlowLogResponse
        /// </returns>
        public async Task<DeactivateFlowLogResponse> DeactivateFlowLogAsync(DeactivateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactivateFlowLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that all resources are disassociated from the ECR.</description></item>
        /// <item><description>You can delete only ECRs that are in the <b>Active</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that all resources are disassociated from the ECR.</description></item>
        /// <item><description>You can delete only ECRs that are in the <b>Active</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that all resources are disassociated from the ECR.</description></item>
        /// <item><description>You can delete only ECRs that are in the <b>Active</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExpressConnectRouterResponse
        /// </returns>
        public DeleteExpressConnectRouterResponse DeleteExpressConnectRouter(DeleteExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that all resources are disassociated from the ECR.</description></item>
        /// <item><description>You can delete only ECRs that are in the <b>Active</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExpressConnectRouterResponse
        /// </returns>
        public async Task<DeleteExpressConnectRouterResponse> DeleteExpressConnectRouterAsync(DeleteExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an Express Connect router (ECR) from a virtual private cloud (VPC) or a transit router (TR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExpressConnectRouterAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExpressConnectRouterAssociationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an Express Connect router (ECR) from a virtual private cloud (VPC) or a transit router (TR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExpressConnectRouterAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExpressConnectRouterAssociationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an Express Connect router (ECR) from a virtual private cloud (VPC) or a transit router (TR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExpressConnectRouterAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExpressConnectRouterAssociationResponse
        /// </returns>
        public DeleteExpressConnectRouterAssociationResponse DeleteExpressConnectRouterAssociation(DeleteExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExpressConnectRouterAssociationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an Express Connect router (ECR) from a virtual private cloud (VPC) or a transit router (TR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteExpressConnectRouterAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExpressConnectRouterAssociationResponse
        /// </returns>
        public async Task<DeleteExpressConnectRouterAssociationResponse> DeleteExpressConnectRouterAssociationAsync(DeleteExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExpressConnectRouterAssociationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowlogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowlogResponse
        /// </returns>
        public DeleteFlowlogResponse DeleteFlowlogWithOptions(DeleteFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowlog",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowlogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowlogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowlogResponse
        /// </returns>
        public async Task<DeleteFlowlogResponse> DeleteFlowlogWithOptionsAsync(DeleteFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowlog",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowlogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowlogRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowlogResponse
        /// </returns>
        public DeleteFlowlogResponse DeleteFlowlog(DeleteFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowlogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a flow log.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFlowlogRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFlowlogResponse
        /// </returns>
        public async Task<DeleteFlowlogResponse> DeleteFlowlogAsync(DeleteFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowlogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries that are disabled on an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisabledExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisabledExpressConnectRouterRouteEntriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries that are disabled on an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisabledExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisabledExpressConnectRouterRouteEntriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries that are disabled on an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisabledExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisabledExpressConnectRouterRouteEntriesResponse
        /// </returns>
        public DescribeDisabledExpressConnectRouterRouteEntriesResponse DescribeDisabledExpressConnectRouterRouteEntries(DescribeDisabledExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisabledExpressConnectRouterRouteEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries that are disabled on an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDisabledExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDisabledExpressConnectRouterRouteEntriesResponse
        /// </returns>
        public async Task<DescribeDisabledExpressConnectRouterRouteEntriesResponse> DescribeDisabledExpressConnectRouterRouteEntriesAsync(DescribeDisabledExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisabledExpressConnectRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Express Connect routers (ECRs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Express Connect routers (ECRs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Express Connect routers (ECRs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterResponse
        /// </returns>
        public DescribeExpressConnectRouterResponse DescribeExpressConnectRouter(DescribeExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Express Connect routers (ECRs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterResponse
        /// </returns>
        public async Task<DescribeExpressConnectRouterResponse> DescribeExpressConnectRouterAsync(DescribeExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical route prefixes of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterAllowedPrefixHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterAllowedPrefixHistoryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical route prefixes of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterAllowedPrefixHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterAllowedPrefixHistoryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical route prefixes of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterAllowedPrefixHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterAllowedPrefixHistoryResponse
        /// </returns>
        public DescribeExpressConnectRouterAllowedPrefixHistoryResponse DescribeExpressConnectRouterAllowedPrefixHistory(DescribeExpressConnectRouterAllowedPrefixHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterAllowedPrefixHistoryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical route prefixes of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterAllowedPrefixHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterAllowedPrefixHistoryResponse
        /// </returns>
        public async Task<DescribeExpressConnectRouterAllowedPrefixHistoryResponse> DescribeExpressConnectRouterAllowedPrefixHistoryAsync(DescribeExpressConnectRouterAllowedPrefixHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterAllowedPrefixHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual private clouds (VPCs) and transit routers (TRs) associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterAssociationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual private clouds (VPCs) and transit routers (TRs) associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterAssociationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual private clouds (VPCs) and transit routers (TRs) associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterAssociationResponse
        /// </returns>
        public DescribeExpressConnectRouterAssociationResponse DescribeExpressConnectRouterAssociation(DescribeExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterAssociationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual private clouds (VPCs) and transit routers (TRs) associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterAssociationResponse
        /// </returns>
        public async Task<DescribeExpressConnectRouterAssociationResponse> DescribeExpressConnectRouterAssociationAsync(DescribeExpressConnectRouterAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterAssociationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual border routers (VBRs) that are associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterChildInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterChildInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual border routers (VBRs) that are associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterChildInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterChildInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual border routers (VBRs) that are associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterChildInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterChildInstanceResponse
        /// </returns>
        public DescribeExpressConnectRouterChildInstanceResponse DescribeExpressConnectRouterChildInstance(DescribeExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterChildInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the virtual border routers (VBRs) that are associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterChildInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterChildInstanceResponse
        /// </returns>
        public async Task<DescribeExpressConnectRouterChildInstanceResponse> DescribeExpressConnectRouterChildInstanceAsync(DescribeExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterChildInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the cross-region forwarding modes of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterInterRegionTransitModeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterInterRegionTransitModeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the cross-region forwarding modes of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterInterRegionTransitModeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterInterRegionTransitModeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the cross-region forwarding modes of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterInterRegionTransitModeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterInterRegionTransitModeResponse
        /// </returns>
        public DescribeExpressConnectRouterInterRegionTransitModeResponse DescribeExpressConnectRouterInterRegionTransitMode(DescribeExpressConnectRouterInterRegionTransitModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterInterRegionTransitModeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the cross-region forwarding modes of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterInterRegionTransitModeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterInterRegionTransitModeResponse
        /// </returns>
        public async Task<DescribeExpressConnectRouterInterRegionTransitModeResponse> DescribeExpressConnectRouterInterRegionTransitModeAsync(DescribeExpressConnectRouterInterRegionTransitModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterInterRegionTransitModeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of regions in which resources related to an Express Connect router (ECR) are deployed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterRegionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of regions in which resources related to an Express Connect router (ECR) are deployed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterRegionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of regions in which resources related to an Express Connect router (ECR) are deployed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterRegionResponse
        /// </returns>
        public DescribeExpressConnectRouterRegionResponse DescribeExpressConnectRouterRegion(DescribeExpressConnectRouterRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterRegionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of regions in which resources related to an Express Connect router (ECR) are deployed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterRegionResponse
        /// </returns>
        public async Task<DescribeExpressConnectRouterRegionResponse> DescribeExpressConnectRouterRegionAsync(DescribeExpressConnectRouterRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterRegionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterRouteEntriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterRouteEntriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterRouteEntriesResponse
        /// </returns>
        public DescribeExpressConnectRouterRouteEntriesResponse DescribeExpressConnectRouterRouteEntries(DescribeExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressConnectRouterRouteEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExpressConnectRouterRouteEntriesResponse
        /// </returns>
        public async Task<DescribeExpressConnectRouterRouteEntriesResponse> DescribeExpressConnectRouterRouteEntriesAsync(DescribeExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressConnectRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries flow logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowLogsResponse
        /// </returns>
        public DescribeFlowLogsResponse DescribeFlowLogsWithOptions(DescribeFlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                query["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowLogs",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries flow logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowLogsResponse
        /// </returns>
        public async Task<DescribeFlowLogsResponse> DescribeFlowLogsWithOptionsAsync(DescribeFlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                query["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowLogs",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries flow logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowLogsResponse
        /// </returns>
        public DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries flow logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFlowLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFlowLogsResponse
        /// </returns>
        public async Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network instances whose permissions are granted to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceGrantedToExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceGrantedToExpressConnectRouterResponse
        /// </returns>
        public DescribeInstanceGrantedToExpressConnectRouterResponse DescribeInstanceGrantedToExpressConnectRouterWithOptions(DescribeInstanceGrantedToExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                body["CallerType"] = request.CallerType;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network instances whose permissions are granted to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceGrantedToExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceGrantedToExpressConnectRouterResponse
        /// </returns>
        public async Task<DescribeInstanceGrantedToExpressConnectRouterResponse> DescribeInstanceGrantedToExpressConnectRouterWithOptionsAsync(DescribeInstanceGrantedToExpressConnectRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallerType))
            {
                body["CallerType"] = request.CallerType;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network instances whose permissions are granted to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceGrantedToExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceGrantedToExpressConnectRouterResponse
        /// </returns>
        public DescribeInstanceGrantedToExpressConnectRouterResponse DescribeInstanceGrantedToExpressConnectRouter(DescribeInstanceGrantedToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceGrantedToExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the network instances whose permissions are granted to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceGrantedToExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceGrantedToExpressConnectRouterResponse
        /// </returns>
        public async Task<DescribeInstanceGrantedToExpressConnectRouterResponse> DescribeInstanceGrantedToExpressConnectRouterAsync(DescribeInstanceGrantedToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceGrantedToExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a virtual border router (VBR) from an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the <b>DetachExpressConnectRouterChildInstance</b> operation to uninstall a VBR from an ECR, make sure that the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachExpressConnectRouterChildInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachExpressConnectRouterChildInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a virtual border router (VBR) from an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the <b>DetachExpressConnectRouterChildInstance</b> operation to uninstall a VBR from an ECR, make sure that the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachExpressConnectRouterChildInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachExpressConnectRouterChildInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a virtual border router (VBR) from an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the <b>DetachExpressConnectRouterChildInstance</b> operation to uninstall a VBR from an ECR, make sure that the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachExpressConnectRouterChildInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachExpressConnectRouterChildInstanceResponse
        /// </returns>
        public DetachExpressConnectRouterChildInstanceResponse DetachExpressConnectRouterChildInstance(DetachExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachExpressConnectRouterChildInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a virtual border router (VBR) from an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call the <b>DetachExpressConnectRouterChildInstance</b> operation to uninstall a VBR from an ECR, make sure that the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachExpressConnectRouterChildInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachExpressConnectRouterChildInstanceResponse
        /// </returns>
        public async Task<DetachExpressConnectRouterChildInstanceResponse> DetachExpressConnectRouterChildInstanceAsync(DetachExpressConnectRouterChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachExpressConnectRouterChildInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableExpressConnectRouterRouteEntriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableExpressConnectRouterRouteEntriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableExpressConnectRouterRouteEntriesResponse
        /// </returns>
        public DisableExpressConnectRouterRouteEntriesResponse DisableExpressConnectRouterRouteEntries(DisableExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableExpressConnectRouterRouteEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableExpressConnectRouterRouteEntriesResponse
        /// </returns>
        public async Task<DisableExpressConnectRouterRouteEntriesResponse> DisableExpressConnectRouterRouteEntriesAsync(DisableExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableExpressConnectRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableExpressConnectRouterRouteEntriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableExpressConnectRouterRouteEntriesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableExpressConnectRouterRouteEntriesResponse
        /// </returns>
        public EnableExpressConnectRouterRouteEntriesResponse EnableExpressConnectRouterRouteEntries(EnableExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableExpressConnectRouterRouteEntriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables route entries of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableExpressConnectRouterRouteEntriesRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableExpressConnectRouterRouteEntriesResponse
        /// </returns>
        public async Task<EnableExpressConnectRouterRouteEntriesResponse> EnableExpressConnectRouterRouteEntriesAsync(EnableExpressConnectRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableExpressConnectRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Express Connect router (ECR) and disassociates the virtual private cloud (VPC), transit router (TR), and virtual border router (VBR) associated with the ECR.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you forcefully delete an ECR, all the resources associated with the ECR are disassociated at a time. Make sure that the disassociation does not affect the stability of your business.</para>
        /// <list type="bullet">
        /// <item><description>You can delete only ECRs that are in the <b>Active</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ForceDeleteExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ForceDeleteExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Express Connect router (ECR) and disassociates the virtual private cloud (VPC), transit router (TR), and virtual border router (VBR) associated with the ECR.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you forcefully delete an ECR, all the resources associated with the ECR are disassociated at a time. Make sure that the disassociation does not affect the stability of your business.</para>
        /// <list type="bullet">
        /// <item><description>You can delete only ECRs that are in the <b>Active</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ForceDeleteExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ForceDeleteExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Express Connect router (ECR) and disassociates the virtual private cloud (VPC), transit router (TR), and virtual border router (VBR) associated with the ECR.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you forcefully delete an ECR, all the resources associated with the ECR are disassociated at a time. Make sure that the disassociation does not affect the stability of your business.</para>
        /// <list type="bullet">
        /// <item><description>You can delete only ECRs that are in the <b>Active</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ForceDeleteExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// ForceDeleteExpressConnectRouterResponse
        /// </returns>
        public ForceDeleteExpressConnectRouterResponse ForceDeleteExpressConnectRouter(ForceDeleteExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForceDeleteExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an Express Connect router (ECR) and disassociates the virtual private cloud (VPC), transit router (TR), and virtual border router (VBR) associated with the ECR.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you forcefully delete an ECR, all the resources associated with the ECR are disassociated at a time. Make sure that the disassociation does not affect the stability of your business.</para>
        /// <list type="bullet">
        /// <item><description>You can delete only ECRs that are in the <b>Active</b> state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ForceDeleteExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// ForceDeleteExpressConnectRouterResponse
        /// </returns>
        public async Task<ForceDeleteExpressConnectRouterResponse> ForceDeleteExpressConnectRouterAsync(ForceDeleteExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForceDeleteExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Grants permissions on a virtual private cloud (VPC) or a virtual border router (VBR) to an Express Connect router (ECR) of another account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you associate a network instance of another account with an ECR, you must grant permissions on the network instance to the ECR.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GrantInstanceToExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantInstanceToExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Grants permissions on a virtual private cloud (VPC) or a virtual border router (VBR) to an Express Connect router (ECR) of another account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you associate a network instance of another account with an ECR, you must grant permissions on the network instance to the ECR.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GrantInstanceToExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GrantInstanceToExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Grants permissions on a virtual private cloud (VPC) or a virtual border router (VBR) to an Express Connect router (ECR) of another account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you associate a network instance of another account with an ECR, you must grant permissions on the network instance to the ECR.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GrantInstanceToExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantInstanceToExpressConnectRouterResponse
        /// </returns>
        public GrantInstanceToExpressConnectRouterResponse GrantInstanceToExpressConnectRouter(GrantInstanceToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantInstanceToExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Grants permissions on a virtual private cloud (VPC) or a virtual border router (VBR) to an Express Connect router (ECR) of another account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you associate a network instance of another account with an ECR, you must grant permissions on the network instance to the ECR.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GrantInstanceToExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// GrantInstanceToExpressConnectRouterResponse
        /// </returns>
        public async Task<GrantInstanceToExpressConnectRouterResponse> GrantInstanceToExpressConnectRouterAsync(GrantInstanceToExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantInstanceToExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of regions in which the Express Connect router (ECR) feature is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExpressConnectRouterSupportedRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExpressConnectRouterSupportedRegionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of regions in which the Express Connect router (ECR) feature is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExpressConnectRouterSupportedRegionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExpressConnectRouterSupportedRegionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of regions in which the Express Connect router (ECR) feature is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExpressConnectRouterSupportedRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExpressConnectRouterSupportedRegionResponse
        /// </returns>
        public ListExpressConnectRouterSupportedRegionResponse ListExpressConnectRouterSupportedRegion(ListExpressConnectRouterSupportedRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExpressConnectRouterSupportedRegionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of regions in which the Express Connect router (ECR) feature is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExpressConnectRouterSupportedRegionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExpressConnectRouterSupportedRegionResponse
        /// </returns>
        public async Task<ListExpressConnectRouterSupportedRegionResponse> ListExpressConnectRouterSupportedRegionAsync(ListExpressConnectRouterSupportedRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExpressConnectRouterSupportedRegionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tags that are added to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tags that are added to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tags that are added to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tags that are added to an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the properties such as the name of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify only properties of ECRs in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the properties such as the name of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify only properties of ECRs in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the properties such as the name of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify only properties of ECRs in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterResponse
        /// </returns>
        public ModifyExpressConnectRouterResponse ModifyExpressConnectRouter(ModifyExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the properties such as the name of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can modify only properties of ECRs in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterResponse
        /// </returns>
        public async Task<ModifyExpressConnectRouterResponse> ModifyExpressConnectRouterAsync(ModifyExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the route prefixes of a virtual private cloud (VPC) or a transit router (TR) that is associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterAssociationAllowedPrefixRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterAssociationAllowedPrefixResponse
        /// </returns>
        public ModifyExpressConnectRouterAssociationAllowedPrefixResponse ModifyExpressConnectRouterAssociationAllowedPrefixWithOptions(ModifyExpressConnectRouterAssociationAllowedPrefixRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixes))
            {
                body["AllowedPrefixes"] = request.AllowedPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixesMode))
            {
                body["AllowedPrefixesMode"] = request.AllowedPrefixesMode;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the route prefixes of a virtual private cloud (VPC) or a transit router (TR) that is associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterAssociationAllowedPrefixRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterAssociationAllowedPrefixResponse
        /// </returns>
        public async Task<ModifyExpressConnectRouterAssociationAllowedPrefixResponse> ModifyExpressConnectRouterAssociationAllowedPrefixWithOptionsAsync(ModifyExpressConnectRouterAssociationAllowedPrefixRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixes))
            {
                body["AllowedPrefixes"] = request.AllowedPrefixes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedPrefixesMode))
            {
                body["AllowedPrefixesMode"] = request.AllowedPrefixesMode;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the route prefixes of a virtual private cloud (VPC) or a transit router (TR) that is associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterAssociationAllowedPrefixRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterAssociationAllowedPrefixResponse
        /// </returns>
        public ModifyExpressConnectRouterAssociationAllowedPrefixResponse ModifyExpressConnectRouterAssociationAllowedPrefix(ModifyExpressConnectRouterAssociationAllowedPrefixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExpressConnectRouterAssociationAllowedPrefixWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the route prefixes of a virtual private cloud (VPC) or a transit router (TR) that is associated with an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterAssociationAllowedPrefixRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterAssociationAllowedPrefixResponse
        /// </returns>
        public async Task<ModifyExpressConnectRouterAssociationAllowedPrefixResponse> ModifyExpressConnectRouterAssociationAllowedPrefixAsync(ModifyExpressConnectRouterAssociationAllowedPrefixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExpressConnectRouterAssociationAllowedPrefixWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the cross-region forwarding mode of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterInterRegionTransitModeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterInterRegionTransitModeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the cross-region forwarding mode of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterInterRegionTransitModeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterInterRegionTransitModeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the cross-region forwarding mode of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterInterRegionTransitModeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterInterRegionTransitModeResponse
        /// </returns>
        public ModifyExpressConnectRouterInterRegionTransitModeResponse ModifyExpressConnectRouterInterRegionTransitMode(ModifyExpressConnectRouterInterRegionTransitModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExpressConnectRouterInterRegionTransitModeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the cross-region forwarding mode of an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyExpressConnectRouterInterRegionTransitModeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyExpressConnectRouterInterRegionTransitModeResponse
        /// </returns>
        public async Task<ModifyExpressConnectRouterInterRegionTransitModeResponse> ModifyExpressConnectRouterInterRegionTransitModeAsync(ModifyExpressConnectRouterInterRegionTransitModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExpressConnectRouterInterRegionTransitModeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name, description, sampling rate, and sampling interval.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFlowLogAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFlowLogAttributeResponse
        /// </returns>
        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeWithOptions(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                query["SamplingRate"] = request.SamplingRate;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                body["FlowLogName"] = request.FlowLogName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowLogAttribute",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name, description, sampling rate, and sampling interval.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFlowLogAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFlowLogAttributeResponse
        /// </returns>
        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeWithOptionsAsync(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SamplingRate))
            {
                query["SamplingRate"] = request.SamplingRate;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                body["FlowLogName"] = request.FlowLogName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowLogAttribute",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name, description, sampling rate, and sampling interval.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFlowLogAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFlowLogAttributeResponse
        /// </returns>
        public ModifyFlowLogAttributeResponse ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowLogAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the name, description, sampling rate, and sampling interval.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFlowLogAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFlowLogAttributeResponse
        /// </returns>
        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeAsync(ModifyFlowLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowLogAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which an Express Connect router (ECR) belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which an Express Connect router (ECR) belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which an Express Connect router (ECR) belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the resource group to which an Express Connect router (ECR) belongs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes permissions on a virtual private cloud (VPC) or a virtual border router (VBR) from an Express Connect router (ECR) owned by another account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeInstanceFromExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeInstanceFromExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes permissions on a virtual private cloud (VPC) or a virtual border router (VBR) from an Express Connect router (ECR) owned by another account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeInstanceFromExpressConnectRouterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeInstanceFromExpressConnectRouterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes permissions on a virtual private cloud (VPC) or a virtual border router (VBR) from an Express Connect router (ECR) owned by another account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeInstanceFromExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeInstanceFromExpressConnectRouterResponse
        /// </returns>
        public RevokeInstanceFromExpressConnectRouterResponse RevokeInstanceFromExpressConnectRouter(RevokeInstanceFromExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeInstanceFromExpressConnectRouterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes permissions on a virtual private cloud (VPC) or a virtual border router (VBR) from an Express Connect router (ECR) owned by another account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeInstanceFromExpressConnectRouterRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeInstanceFromExpressConnectRouterResponse
        /// </returns>
        public async Task<RevokeInstanceFromExpressConnectRouterResponse> RevokeInstanceFromExpressConnectRouterAsync(RevokeInstanceFromExpressConnectRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeInstanceFromExpressConnectRouterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronizes the forwarding bandwidth limit between regions for an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates are allowed only when the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SynchronizeExpressConnectRouterInterRegionBandwidthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SynchronizeExpressConnectRouterInterRegionBandwidthResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronizes the forwarding bandwidth limit between regions for an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates are allowed only when the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SynchronizeExpressConnectRouterInterRegionBandwidthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SynchronizeExpressConnectRouterInterRegionBandwidthResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronizes the forwarding bandwidth limit between regions for an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates are allowed only when the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SynchronizeExpressConnectRouterInterRegionBandwidthRequest
        /// </param>
        /// 
        /// <returns>
        /// SynchronizeExpressConnectRouterInterRegionBandwidthResponse
        /// </returns>
        public SynchronizeExpressConnectRouterInterRegionBandwidthResponse SynchronizeExpressConnectRouterInterRegionBandwidth(SynchronizeExpressConnectRouterInterRegionBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SynchronizeExpressConnectRouterInterRegionBandwidthWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronizes the forwarding bandwidth limit between regions for an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates are allowed only when the ECR is in the <b>Active</b> state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SynchronizeExpressConnectRouterInterRegionBandwidthRequest
        /// </param>
        /// 
        /// <returns>
        /// SynchronizeExpressConnectRouterInterRegionBandwidthResponse
        /// </returns>
        public async Task<SynchronizeExpressConnectRouterInterRegionBandwidthResponse> SynchronizeExpressConnectRouterInterRegionBandwidthAsync(SynchronizeExpressConnectRouterInterRegionBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SynchronizeExpressConnectRouterInterRegionBandwidthWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an Express Connect router (ECR). You can add tags to only one ECR each time you call this operation. You can add multiple tags at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an Express Connect router (ECR). You can add tags to only one ECR each time you call this operation. You can add multiple tags at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an Express Connect router (ECR). You can add tags to only one ECR each time you call this operation. You can add multiple tags at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an Express Connect router (ECR). You can add tags to only one ECR each time you call this operation. You can add multiple tags at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2023-09-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from an Express Connect router (ECR).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
