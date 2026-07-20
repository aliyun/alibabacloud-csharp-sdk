// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.RiskManagement20260424.Models;

namespace AlibabaCloud.SDK.RiskManagement20260424
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("riskmanagement", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>sas-绑定授权到机器</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BindAuthToMachineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAuthToMachineResponse
        /// </returns>
        public BindAuthToMachineResponse BindAuthToMachineWithOptions(BindAuthToMachineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BindAuthToMachineShrinkRequest request = new BindAuthToMachineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAuthToMachine",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAuthToMachineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-绑定授权到机器</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BindAuthToMachineRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindAuthToMachineResponse
        /// </returns>
        public async Task<BindAuthToMachineResponse> BindAuthToMachineWithOptionsAsync(BindAuthToMachineRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BindAuthToMachineShrinkRequest request = new BindAuthToMachineShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAuthToMachine",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAuthToMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-绑定授权到机器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAuthToMachineRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAuthToMachineResponse
        /// </returns>
        public BindAuthToMachineResponse BindAuthToMachine(BindAuthToMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAuthToMachineWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-绑定授权到机器</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindAuthToMachineRequest
        /// </param>
        /// 
        /// <returns>
        /// BindAuthToMachineResponse
        /// </returns>
        public async Task<BindAuthToMachineResponse> BindAuthToMachineAsync(BindAuthToMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAuthToMachineWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-初始化云安全中心模块规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSasTrialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSasTrialResponse
        /// </returns>
        public CreateSasTrialResponse CreateSasTrialWithOptions(CreateSasTrialRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSasTrialShrinkRequest request = new CreateSasTrialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSasTrial",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSasTrialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-初始化云安全中心模块规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSasTrialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSasTrialResponse
        /// </returns>
        public async Task<CreateSasTrialResponse> CreateSasTrialWithOptionsAsync(CreateSasTrialRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSasTrialShrinkRequest request = new CreateSasTrialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSasTrial",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSasTrialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-初始化云安全中心模块规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSasTrialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSasTrialResponse
        /// </returns>
        public CreateSasTrialResponse CreateSasTrial(CreateSasTrialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSasTrialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-初始化云安全中心模块规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSasTrialRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSasTrialResponse
        /// </returns>
        public async Task<CreateSasTrialResponse> CreateSasTrialAsync(CreateSasTrialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSasTrialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-创建服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleWithOptions(CreateServiceLinkedRoleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceLinkedRoleShrinkRequest request = new CreateServiceLinkedRoleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRole",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-创建服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateServiceLinkedRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleWithOptionsAsync(CreateServiceLinkedRoleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceLinkedRoleShrinkRequest request = new CreateServiceLinkedRoleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRole",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-创建服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-创建服务关联角色</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceLinkedRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceLinkedRoleResponse
        /// </returns>
        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建全盘扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirusScanOnceTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirusScanOnceTaskResponse
        /// </returns>
        public CreateVirusScanOnceTaskResponse CreateVirusScanOnceTaskWithOptions(CreateVirusScanOnceTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirusScanOnceTask",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirusScanOnceTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建全盘扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirusScanOnceTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirusScanOnceTaskResponse
        /// </returns>
        public async Task<CreateVirusScanOnceTaskResponse> CreateVirusScanOnceTaskWithOptionsAsync(CreateVirusScanOnceTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirusScanOnceTask",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirusScanOnceTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建全盘扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirusScanOnceTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirusScanOnceTaskResponse
        /// </returns>
        public CreateVirusScanOnceTaskResponse CreateVirusScanOnceTask(CreateVirusScanOnceTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirusScanOnceTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建全盘扫描任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirusScanOnceTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirusScanOnceTaskResponse
        /// </returns>
        public async Task<CreateVirusScanOnceTaskResponse> CreateVirusScanOnceTaskAsync(CreateVirusScanOnceTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirusScanOnceTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询云安全中心实例列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCloudCenterInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudCenterInstancesResponse
        /// </returns>
        public DescribeCloudCenterInstancesResponse DescribeCloudCenterInstancesWithOptions(DescribeCloudCenterInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCloudCenterInstancesShrinkRequest request = new DescribeCloudCenterInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudCenterInstances",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudCenterInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询云安全中心实例列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCloudCenterInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudCenterInstancesResponse
        /// </returns>
        public async Task<DescribeCloudCenterInstancesResponse> DescribeCloudCenterInstancesWithOptionsAsync(DescribeCloudCenterInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCloudCenterInstancesShrinkRequest request = new DescribeCloudCenterInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudCenterInstances",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudCenterInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询云安全中心实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudCenterInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudCenterInstancesResponse
        /// </returns>
        public DescribeCloudCenterInstancesResponse DescribeCloudCenterInstances(DescribeCloudCenterInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudCenterInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询云安全中心实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudCenterInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudCenterInstancesResponse
        /// </returns>
        public async Task<DescribeCloudCenterInstancesResponse> DescribeCloudCenterInstancesAsync(DescribeCloudCenterInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudCenterInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询服务关联角色状态</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeServiceLinkedRoleStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLinkedRoleStatusResponse
        /// </returns>
        public DescribeServiceLinkedRoleStatusResponse DescribeServiceLinkedRoleStatusWithOptions(DescribeServiceLinkedRoleStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeServiceLinkedRoleStatusShrinkRequest request = new DescribeServiceLinkedRoleStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceLinkedRoleStatus",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceLinkedRoleStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询服务关联角色状态</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeServiceLinkedRoleStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLinkedRoleStatusResponse
        /// </returns>
        public async Task<DescribeServiceLinkedRoleStatusResponse> DescribeServiceLinkedRoleStatusWithOptionsAsync(DescribeServiceLinkedRoleStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeServiceLinkedRoleStatusShrinkRequest request = new DescribeServiceLinkedRoleStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceLinkedRoleStatus",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceLinkedRoleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询服务关联角色状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLinkedRoleStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLinkedRoleStatusResponse
        /// </returns>
        public DescribeServiceLinkedRoleStatusResponse DescribeServiceLinkedRoleStatus(DescribeServiceLinkedRoleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceLinkedRoleStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询服务关联角色状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLinkedRoleStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLinkedRoleStatusResponse
        /// </returns>
        public async Task<DescribeServiceLinkedRoleStatusResponse> DescribeServiceLinkedRoleStatusAsync(DescribeServiceLinkedRoleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceLinkedRoleStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询安全告警事件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSuspEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public DescribeSuspEventsResponse DescribeSuspEventsWithOptions(DescribeSuspEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSuspEventsShrinkRequest request = new DescribeSuspEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSuspEvents",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询安全告警事件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeSuspEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsWithOptionsAsync(DescribeSuspEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeSuspEventsShrinkRequest request = new DescribeSuspEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSuspEvents",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSuspEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询安全告警事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public DescribeSuspEventsResponse DescribeSuspEvents(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSuspEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查询安全告警事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSuspEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSuspEventsResponse
        /// </returns>
        public async Task<DescribeSuspEventsResponse> DescribeSuspEventsAsync(DescribeSuspEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSuspEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查看已购买的云安全中心实例的版本详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeVersionConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVersionConfigResponse
        /// </returns>
        public DescribeVersionConfigResponse DescribeVersionConfigWithOptions(DescribeVersionConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeVersionConfigShrinkRequest request = new DescribeVersionConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVersionConfig",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVersionConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查看已购买的云安全中心实例的版本详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeVersionConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVersionConfigResponse
        /// </returns>
        public async Task<DescribeVersionConfigResponse> DescribeVersionConfigWithOptionsAsync(DescribeVersionConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeVersionConfigShrinkRequest request = new DescribeVersionConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVersionConfig",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVersionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查看已购买的云安全中心实例的版本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVersionConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVersionConfigResponse
        /// </returns>
        public DescribeVersionConfigResponse DescribeVersionConfig(DescribeVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVersionConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-查看已购买的云安全中心实例的版本详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVersionConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVersionConfigResponse
        /// </returns>
        public async Task<DescribeVersionConfigResponse> DescribeVersionConfigAsync(DescribeVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVersionConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取告警记录分析结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAlertRecordAnalysisResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlertRecordAnalysisResultResponse
        /// </returns>
        public GetAlertRecordAnalysisResultResponse GetAlertRecordAnalysisResultWithOptions(GetAlertRecordAnalysisResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAlertRecordAnalysisResultShrinkRequest request = new GetAlertRecordAnalysisResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UniqueTagList))
            {
                request.UniqueTagListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UniqueTagList, "UniqueTagList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmUniqueInfo))
            {
                query["AlarmUniqueInfo"] = request.AlarmUniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["AliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueInfo))
            {
                query["UniqueInfo"] = request.UniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueTagListShrink))
            {
                query["UniqueTagList"] = request.UniqueTagListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlertRecordAnalysisResult",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertRecordAnalysisResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取告警记录分析结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAlertRecordAnalysisResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlertRecordAnalysisResultResponse
        /// </returns>
        public async Task<GetAlertRecordAnalysisResultResponse> GetAlertRecordAnalysisResultWithOptionsAsync(GetAlertRecordAnalysisResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAlertRecordAnalysisResultShrinkRequest request = new GetAlertRecordAnalysisResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UniqueTagList))
            {
                request.UniqueTagListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UniqueTagList, "UniqueTagList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlarmUniqueInfo))
            {
                query["AlarmUniqueInfo"] = request.AlarmUniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["AliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueInfo))
            {
                query["UniqueInfo"] = request.UniqueInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueTagListShrink))
            {
                query["UniqueTagList"] = request.UniqueTagListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlertRecordAnalysisResult",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertRecordAnalysisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取告警记录分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertRecordAnalysisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlertRecordAnalysisResultResponse
        /// </returns>
        public GetAlertRecordAnalysisResultResponse GetAlertRecordAnalysisResult(GetAlertRecordAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlertRecordAnalysisResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取告警记录分析结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAlertRecordAnalysisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlertRecordAnalysisResultResponse
        /// </returns>
        public async Task<GetAlertRecordAnalysisResultResponse> GetAlertRecordAnalysisResultAsync(GetAlertRecordAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlertRecordAnalysisResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用云安全中心部分接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAliYunSafeCenterResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAliYunSafeCenterResultResponse
        /// </returns>
        public GetAliYunSafeCenterResultResponse GetAliYunSafeCenterResultWithOptions(GetAliYunSafeCenterResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAliYunSafeCenterResultShrinkRequest request = new GetAliYunSafeCenterResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateSimilarSecurityEventsQueryTaskRequest))
            {
                request.CreateSimilarSecurityEventsQueryTaskRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateSimilarSecurityEventsQueryTaskRequest, "CreateSimilarSecurityEventsQueryTaskRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DescribeInstancesFullStatusRequest))
            {
                request.DescribeInstancesFullStatusRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DescribeInstancesFullStatusRequest, "DescribeInstancesFullStatusRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DescribeSecurityEventOperationStatusRequest))
            {
                request.DescribeSecurityEventOperationStatusRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DescribeSecurityEventOperationStatusRequest, "DescribeSecurityEventOperationStatusRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DescribeSimilarSecurityEventsRequest))
            {
                request.DescribeSimilarSecurityEventsRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DescribeSimilarSecurityEventsRequest, "DescribeSimilarSecurityEventsRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GetAssetDetailByUuidRequest))
            {
                request.GetAssetDetailByUuidRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GetAssetDetailByUuidRequest, "GetAssetDetailByUuidRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HandleSecurityEventsRequest))
            {
                request.HandleSecurityEventsRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HandleSecurityEventsRequest, "HandleSecurityEventsRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HandleSimilarSecurityEventsRequest))
            {
                request.HandleSimilarSecurityEventsRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HandleSimilarSecurityEventsRequest, "HandleSimilarSecurityEventsRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListInstancesRequest))
            {
                request.ListInstancesRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListInstancesRequest, "ListInstancesRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateSimilarSecurityEventsQueryTaskRequestShrink))
            {
                query["CreateSimilarSecurityEventsQueryTaskRequest"] = request.CreateSimilarSecurityEventsQueryTaskRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescribeInstancesFullStatusRequestShrink))
            {
                query["DescribeInstancesFullStatusRequest"] = request.DescribeInstancesFullStatusRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescribeSecurityEventOperationStatusRequestShrink))
            {
                query["DescribeSecurityEventOperationStatusRequest"] = request.DescribeSecurityEventOperationStatusRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescribeSimilarSecurityEventsRequestShrink))
            {
                query["DescribeSimilarSecurityEventsRequest"] = request.DescribeSimilarSecurityEventsRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetAssetDetailByUuidRequestShrink))
            {
                query["GetAssetDetailByUuidRequest"] = request.GetAssetDetailByUuidRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleSecurityEventsRequestShrink))
            {
                query["HandleSecurityEventsRequest"] = request.HandleSecurityEventsRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleSimilarSecurityEventsRequestShrink))
            {
                query["HandleSimilarSecurityEventsRequest"] = request.HandleSimilarSecurityEventsRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceCode))
            {
                query["InterfaceCode"] = request.InterfaceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListInstancesRequestShrink))
            {
                query["ListInstancesRequest"] = request.ListInstancesRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAliYunSafeCenterResult",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliYunSafeCenterResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用云安全中心部分接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetAliYunSafeCenterResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAliYunSafeCenterResultResponse
        /// </returns>
        public async Task<GetAliYunSafeCenterResultResponse> GetAliYunSafeCenterResultWithOptionsAsync(GetAliYunSafeCenterResultRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAliYunSafeCenterResultShrinkRequest request = new GetAliYunSafeCenterResultShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CreateSimilarSecurityEventsQueryTaskRequest))
            {
                request.CreateSimilarSecurityEventsQueryTaskRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CreateSimilarSecurityEventsQueryTaskRequest, "CreateSimilarSecurityEventsQueryTaskRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DescribeInstancesFullStatusRequest))
            {
                request.DescribeInstancesFullStatusRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DescribeInstancesFullStatusRequest, "DescribeInstancesFullStatusRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DescribeSecurityEventOperationStatusRequest))
            {
                request.DescribeSecurityEventOperationStatusRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DescribeSecurityEventOperationStatusRequest, "DescribeSecurityEventOperationStatusRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DescribeSimilarSecurityEventsRequest))
            {
                request.DescribeSimilarSecurityEventsRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DescribeSimilarSecurityEventsRequest, "DescribeSimilarSecurityEventsRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GetAssetDetailByUuidRequest))
            {
                request.GetAssetDetailByUuidRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GetAssetDetailByUuidRequest, "GetAssetDetailByUuidRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HandleSecurityEventsRequest))
            {
                request.HandleSecurityEventsRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HandleSecurityEventsRequest, "HandleSecurityEventsRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HandleSimilarSecurityEventsRequest))
            {
                request.HandleSimilarSecurityEventsRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HandleSimilarSecurityEventsRequest, "HandleSimilarSecurityEventsRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListInstancesRequest))
            {
                request.ListInstancesRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListInstancesRequest, "ListInstancesRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateSimilarSecurityEventsQueryTaskRequestShrink))
            {
                query["CreateSimilarSecurityEventsQueryTaskRequest"] = request.CreateSimilarSecurityEventsQueryTaskRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescribeInstancesFullStatusRequestShrink))
            {
                query["DescribeInstancesFullStatusRequest"] = request.DescribeInstancesFullStatusRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescribeSecurityEventOperationStatusRequestShrink))
            {
                query["DescribeSecurityEventOperationStatusRequest"] = request.DescribeSecurityEventOperationStatusRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DescribeSimilarSecurityEventsRequestShrink))
            {
                query["DescribeSimilarSecurityEventsRequest"] = request.DescribeSimilarSecurityEventsRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GetAssetDetailByUuidRequestShrink))
            {
                query["GetAssetDetailByUuidRequest"] = request.GetAssetDetailByUuidRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleSecurityEventsRequestShrink))
            {
                query["HandleSecurityEventsRequest"] = request.HandleSecurityEventsRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleSimilarSecurityEventsRequestShrink))
            {
                query["HandleSimilarSecurityEventsRequest"] = request.HandleSimilarSecurityEventsRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceCode))
            {
                query["InterfaceCode"] = request.InterfaceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListInstancesRequestShrink))
            {
                query["ListInstancesRequest"] = request.ListInstancesRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAliYunSafeCenterResult",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAliYunSafeCenterResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用云安全中心部分接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAliYunSafeCenterResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAliYunSafeCenterResultResponse
        /// </returns>
        public GetAliYunSafeCenterResultResponse GetAliYunSafeCenterResult(GetAliYunSafeCenterResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAliYunSafeCenterResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用云安全中心部分接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAliYunSafeCenterResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAliYunSafeCenterResultResponse
        /// </returns>
        public async Task<GetAliYunSafeCenterResultResponse> GetAliYunSafeCenterResultAsync(GetAliYunSafeCenterResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAliYunSafeCenterResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-获取能否试用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCanTrySasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCanTrySasResponse
        /// </returns>
        public GetCanTrySasResponse GetCanTrySasWithOptions(GetCanTrySasRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCanTrySasShrinkRequest request = new GetCanTrySasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCanTrySas",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCanTrySasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-获取能否试用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetCanTrySasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCanTrySasResponse
        /// </returns>
        public async Task<GetCanTrySasResponse> GetCanTrySasWithOptionsAsync(GetCanTrySasRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetCanTrySasShrinkRequest request = new GetCanTrySasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCanTrySas",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCanTrySasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-获取能否试用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCanTrySasRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCanTrySasResponse
        /// </returns>
        public GetCanTrySasResponse GetCanTrySas(GetCanTrySasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCanTrySasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-获取能否试用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCanTrySasRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCanTrySasResponse
        /// </returns>
        public async Task<GetCanTrySasResponse> GetCanTrySasAsync(GetCanTrySasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCanTrySasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全合规包id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCompliancePackIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCompliancePackIdResponse
        /// </returns>
        public GetCompliancePackIdResponse GetCompliancePackIdWithOptions(GetCompliancePackIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCompliancePackId",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCompliancePackIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全合规包id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCompliancePackIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCompliancePackIdResponse
        /// </returns>
        public async Task<GetCompliancePackIdResponse> GetCompliancePackIdWithOptionsAsync(GetCompliancePackIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCompliancePackId",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCompliancePackIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全合规包id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCompliancePackIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCompliancePackIdResponse
        /// </returns>
        public GetCompliancePackIdResponse GetCompliancePackId(GetCompliancePackIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCompliancePackIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全合规包id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCompliancePackIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCompliancePackIdResponse
        /// </returns>
        public async Task<GetCompliancePackIdResponse> GetCompliancePackIdAsync(GetCompliancePackIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCompliancePackIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一键处置赋权状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDisposalToolStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDisposalToolStatusResponse
        /// </returns>
        public GetDisposalToolStatusResponse GetDisposalToolStatusWithOptions(GetDisposalToolStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDisposalToolStatus",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDisposalToolStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一键处置赋权状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDisposalToolStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDisposalToolStatusResponse
        /// </returns>
        public async Task<GetDisposalToolStatusResponse> GetDisposalToolStatusWithOptionsAsync(GetDisposalToolStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDisposalToolStatus",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDisposalToolStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一键处置赋权状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDisposalToolStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDisposalToolStatusResponse
        /// </returns>
        public GetDisposalToolStatusResponse GetDisposalToolStatus(GetDisposalToolStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDisposalToolStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一键处置赋权状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDisposalToolStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDisposalToolStatusResponse
        /// </returns>
        public async Task<GetDisposalToolStatusResponse> GetDisposalToolStatusAsync(GetDisposalToolStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDisposalToolStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户确认安全联系人记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationClickRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationClickRecordResponse
        /// </returns>
        public GetNotificationClickRecordResponse GetNotificationClickRecordWithOptions(GetNotificationClickRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotificationClickRecord",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotificationClickRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户确认安全联系人记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationClickRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationClickRecordResponse
        /// </returns>
        public async Task<GetNotificationClickRecordResponse> GetNotificationClickRecordWithOptionsAsync(GetNotificationClickRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotificationClickRecord",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotificationClickRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户确认安全联系人记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationClickRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationClickRecordResponse
        /// </returns>
        public GetNotificationClickRecordResponse GetNotificationClickRecord(GetNotificationClickRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNotificationClickRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取用户确认安全联系人记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationClickRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationClickRecordResponse
        /// </returns>
        public async Task<GetNotificationClickRecordResponse> GetNotificationClickRecordAsync(GetNotificationClickRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNotificationClickRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全联系人全部信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationContactsResponse
        /// </returns>
        public GetNotificationContactsResponse GetNotificationContactsWithOptions(GetNotificationContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotificationContacts",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotificationContactsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全联系人全部信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationContactsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationContactsResponse
        /// </returns>
        public async Task<GetNotificationContactsResponse> GetNotificationContactsWithOptionsAsync(GetNotificationContactsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotificationContacts",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotificationContactsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全联系人全部信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationContactsResponse
        /// </returns>
        public GetNotificationContactsResponse GetNotificationContacts(GetNotificationContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNotificationContactsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全联系人全部信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationContactsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationContactsResponse
        /// </returns>
        public async Task<GetNotificationContactsResponse> GetNotificationContactsAsync(GetNotificationContactsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNotificationContactsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全联系人待处理数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationPendNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationPendNumberResponse
        /// </returns>
        public GetNotificationPendNumberResponse GetNotificationPendNumberWithOptions(GetNotificationPendNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotificationPendNumber",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotificationPendNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全联系人待处理数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationPendNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationPendNumberResponse
        /// </returns>
        public async Task<GetNotificationPendNumberResponse> GetNotificationPendNumberWithOptionsAsync(GetNotificationPendNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNotificationPendNumber",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNotificationPendNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全联系人待处理数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationPendNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationPendNumberResponse
        /// </returns>
        public GetNotificationPendNumberResponse GetNotificationPendNumber(GetNotificationPendNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNotificationPendNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全联系人待处理数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNotificationPendNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNotificationPendNumberResponse
        /// </returns>
        public async Task<GetNotificationPendNumberResponse> GetNotificationPendNumberAsync(GetNotificationPendNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNotificationPendNumberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源管控事件详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetResourceControlEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceControlEventResponse
        /// </returns>
        public GetResourceControlEventResponse GetResourceControlEventWithOptions(GetResourceControlEventRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourceControlEventShrinkRequest request = new GetResourceControlEventShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventIdList))
            {
                request.EventIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventIdList, "EventIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["AliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventIdListShrink))
            {
                query["EventIdList"] = request.EventIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceControlEvent",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceControlEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源管控事件详情</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetResourceControlEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceControlEventResponse
        /// </returns>
        public async Task<GetResourceControlEventResponse> GetResourceControlEventWithOptionsAsync(GetResourceControlEventRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetResourceControlEventShrinkRequest request = new GetResourceControlEventShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventIdList))
            {
                request.EventIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventIdList, "EventIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["AliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventIdListShrink))
            {
                query["EventIdList"] = request.EventIdListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceControlEvent",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceControlEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源管控事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceControlEventRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceControlEventResponse
        /// </returns>
        public GetResourceControlEventResponse GetResourceControlEvent(GetResourceControlEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceControlEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源管控事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceControlEventRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceControlEventResponse
        /// </returns>
        public async Task<GetResourceControlEventResponse> GetResourceControlEventAsync(GetResourceControlEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceControlEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全体检基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityCheckBaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityCheckBaseInfoResponse
        /// </returns>
        public GetSecurityCheckBaseInfoResponse GetSecurityCheckBaseInfoWithOptions(GetSecurityCheckBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityCheckBaseInfo",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityCheckBaseInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全体检基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityCheckBaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityCheckBaseInfoResponse
        /// </returns>
        public async Task<GetSecurityCheckBaseInfoResponse> GetSecurityCheckBaseInfoWithOptionsAsync(GetSecurityCheckBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityCheckBaseInfo",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityCheckBaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全体检基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityCheckBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityCheckBaseInfoResponse
        /// </returns>
        public GetSecurityCheckBaseInfoResponse GetSecurityCheckBaseInfo(GetSecurityCheckBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecurityCheckBaseInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全体检基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityCheckBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityCheckBaseInfoResponse
        /// </returns>
        public async Task<GetSecurityCheckBaseInfoResponse> GetSecurityCheckBaseInfoAsync(GetSecurityCheckBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecurityCheckBaseInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全检查结果基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityCheckResultBaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityCheckResultBaseInfoResponse
        /// </returns>
        public GetSecurityCheckResultBaseInfoResponse GetSecurityCheckResultBaseInfoWithOptions(GetSecurityCheckResultBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityCheckResultBaseInfo",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityCheckResultBaseInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全检查结果基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityCheckResultBaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityCheckResultBaseInfoResponse
        /// </returns>
        public async Task<GetSecurityCheckResultBaseInfoResponse> GetSecurityCheckResultBaseInfoWithOptionsAsync(GetSecurityCheckResultBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityCheckResultBaseInfo",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityCheckResultBaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全检查结果基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityCheckResultBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityCheckResultBaseInfoResponse
        /// </returns>
        public GetSecurityCheckResultBaseInfoResponse GetSecurityCheckResultBaseInfo(GetSecurityCheckResultBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecurityCheckResultBaseInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全检查结果基础信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityCheckResultBaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityCheckResultBaseInfoResponse
        /// </returns>
        public async Task<GetSecurityCheckResultBaseInfoResponse> GetSecurityCheckResultBaseInfoAsync(GetSecurityCheckResultBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecurityCheckResultBaseInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全优化建议列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSecuritySuggestionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecuritySuggestionListResponse
        /// </returns>
        public GetSecuritySuggestionListResponse GetSecuritySuggestionListWithOptions(GetSecuritySuggestionListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSecuritySuggestionListShrinkRequest request = new GetSecuritySuggestionListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListConfigRulesRequest))
            {
                request.ListConfigRulesRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListConfigRulesRequest, "ListConfigRulesRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListConfigRulesRequestShrink))
            {
                query["ListConfigRulesRequest"] = request.ListConfigRulesRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecuritySuggestionList",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecuritySuggestionListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全优化建议列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetSecuritySuggestionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecuritySuggestionListResponse
        /// </returns>
        public async Task<GetSecuritySuggestionListResponse> GetSecuritySuggestionListWithOptionsAsync(GetSecuritySuggestionListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetSecuritySuggestionListShrinkRequest request = new GetSecuritySuggestionListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ListConfigRulesRequest))
            {
                request.ListConfigRulesRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ListConfigRulesRequest, "ListConfigRulesRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListConfigRulesRequestShrink))
            {
                query["ListConfigRulesRequest"] = request.ListConfigRulesRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecuritySuggestionList",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecuritySuggestionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全优化建议列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecuritySuggestionListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecuritySuggestionListResponse
        /// </returns>
        public GetSecuritySuggestionListResponse GetSecuritySuggestionList(GetSecuritySuggestionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecuritySuggestionListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全优化建议列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecuritySuggestionListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecuritySuggestionListResponse
        /// </returns>
        public async Task<GetSecuritySuggestionListResponse> GetSecuritySuggestionListAsync(GetSecuritySuggestionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecuritySuggestionListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全优化建议条数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecuritySuggestionNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecuritySuggestionNumberResponse
        /// </returns>
        public GetSecuritySuggestionNumberResponse GetSecuritySuggestionNumberWithOptions(GetSecuritySuggestionNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecuritySuggestionNumber",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecuritySuggestionNumberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全优化建议条数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecuritySuggestionNumberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecuritySuggestionNumberResponse
        /// </returns>
        public async Task<GetSecuritySuggestionNumberResponse> GetSecuritySuggestionNumberWithOptionsAsync(GetSecuritySuggestionNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecuritySuggestionNumber",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecuritySuggestionNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全优化建议条数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecuritySuggestionNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecuritySuggestionNumberResponse
        /// </returns>
        public GetSecuritySuggestionNumberResponse GetSecuritySuggestionNumber(GetSecuritySuggestionNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecuritySuggestionNumberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取安全优化建议条数</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecuritySuggestionNumberRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecuritySuggestionNumberResponse
        /// </returns>
        public async Task<GetSecuritySuggestionNumberResponse> GetSecuritySuggestionNumberAsync(GetSecuritySuggestionNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecuritySuggestionNumberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务关联角色状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceLinkedRoleStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceLinkedRoleStatusResponse
        /// </returns>
        public GetServiceLinkedRoleStatusResponse GetServiceLinkedRoleStatusWithOptions(GetServiceLinkedRoleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceLinkedRoleStatus",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceLinkedRoleStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务关联角色状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceLinkedRoleStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetServiceLinkedRoleStatusResponse
        /// </returns>
        public async Task<GetServiceLinkedRoleStatusResponse> GetServiceLinkedRoleStatusWithOptionsAsync(GetServiceLinkedRoleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetServiceLinkedRoleStatus",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetServiceLinkedRoleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务关联角色状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceLinkedRoleStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceLinkedRoleStatusResponse
        /// </returns>
        public GetServiceLinkedRoleStatusResponse GetServiceLinkedRoleStatus(GetServiceLinkedRoleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceLinkedRoleStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取服务关联角色状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetServiceLinkedRoleStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetServiceLinkedRoleStatusResponse
        /// </returns>
        public async Task<GetServiceLinkedRoleStatusResponse> GetServiceLinkedRoleStatusAsync(GetServiceLinkedRoleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceLinkedRoleStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-获取有效抵扣实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetValidDeductInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetValidDeductInstancesResponse
        /// </returns>
        public GetValidDeductInstancesResponse GetValidDeductInstancesWithOptions(GetValidDeductInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetValidDeductInstancesShrinkRequest request = new GetValidDeductInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetValidDeductInstances",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetValidDeductInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-获取有效抵扣实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetValidDeductInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetValidDeductInstancesResponse
        /// </returns>
        public async Task<GetValidDeductInstancesResponse> GetValidDeductInstancesWithOptionsAsync(GetValidDeductInstancesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetValidDeductInstancesShrinkRequest request = new GetValidDeductInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetValidDeductInstances",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetValidDeductInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-获取有效抵扣实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetValidDeductInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetValidDeductInstancesResponse
        /// </returns>
        public GetValidDeductInstancesResponse GetValidDeductInstances(GetValidDeductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetValidDeductInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-获取有效抵扣实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetValidDeductInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetValidDeductInstancesResponse
        /// </returns>
        public async Task<GetValidDeductInstancesResponse> GetValidDeductInstancesAsync(GetValidDeductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetValidDeductInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-初始化云安全中心模块规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InitSasModuleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitSasModuleRuleResponse
        /// </returns>
        public InitSasModuleRuleResponse InitSasModuleRuleWithOptions(InitSasModuleRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InitSasModuleRuleShrinkRequest request = new InitSasModuleRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Instances))
            {
                request.InstancesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Instances, "Instances", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBind))
            {
                query["AutoBind"] = request.AutoBind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstancesShrink))
            {
                query["Instances"] = request.InstancesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsTrial))
            {
                query["IsTrial"] = request.IsTrial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitSasModuleRule",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitSasModuleRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-初始化云安全中心模块规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InitSasModuleRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InitSasModuleRuleResponse
        /// </returns>
        public async Task<InitSasModuleRuleResponse> InitSasModuleRuleWithOptionsAsync(InitSasModuleRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InitSasModuleRuleShrinkRequest request = new InitSasModuleRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Instances))
            {
                request.InstancesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Instances, "Instances", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoBind))
            {
                query["AutoBind"] = request.AutoBind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstancesShrink))
            {
                query["Instances"] = request.InstancesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsTrial))
            {
                query["IsTrial"] = request.IsTrial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitSasModuleRule",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitSasModuleRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-初始化云安全中心模块规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitSasModuleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// InitSasModuleRuleResponse
        /// </returns>
        public InitSasModuleRuleResponse InitSasModuleRule(InitSasModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitSasModuleRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-初始化云安全中心模块规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InitSasModuleRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// InitSasModuleRuleResponse
        /// </returns>
        public async Task<InitSasModuleRuleResponse> InitSasModuleRuleAsync(InitSasModuleRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitSasModuleRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询全盘扫描结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirusScanMachineEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirusScanMachineEventResponse
        /// </returns>
        public ListVirusScanMachineEventResponse ListVirusScanMachineEventWithOptions(ListVirusScanMachineEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTaskId))
            {
                query["OperateTaskId"] = request.OperateTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirusScanMachineEvent",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirusScanMachineEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询全盘扫描结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirusScanMachineEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirusScanMachineEventResponse
        /// </returns>
        public async Task<ListVirusScanMachineEventResponse> ListVirusScanMachineEventWithOptionsAsync(ListVirusScanMachineEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateTaskId))
            {
                query["OperateTaskId"] = request.OperateTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirusScanMachineEvent",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirusScanMachineEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询全盘扫描结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirusScanMachineEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirusScanMachineEventResponse
        /// </returns>
        public ListVirusScanMachineEventResponse ListVirusScanMachineEvent(ListVirusScanMachineEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVirusScanMachineEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询全盘扫描结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirusScanMachineEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirusScanMachineEventResponse
        /// </returns>
        public async Task<ListVirusScanMachineEventResponse> ListVirusScanMachineEventAsync(ListVirusScanMachineEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVirusScanMachineEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-开启试用套餐</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenTrialPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenTrialPackageResponse
        /// </returns>
        public OpenTrialPackageResponse OpenTrialPackageWithOptions(OpenTrialPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCloseSwitch))
            {
                query["AutoCloseSwitch"] = request.AutoCloseSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenTrialPackage",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenTrialPackageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-开启试用套餐</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenTrialPackageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenTrialPackageResponse
        /// </returns>
        public async Task<OpenTrialPackageResponse> OpenTrialPackageWithOptionsAsync(OpenTrialPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCloseSwitch))
            {
                query["AutoCloseSwitch"] = request.AutoCloseSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenTrialPackage",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenTrialPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-开启试用套餐</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenTrialPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenTrialPackageResponse
        /// </returns>
        public OpenTrialPackageResponse OpenTrialPackage(OpenTrialPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenTrialPackageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-开启试用套餐</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenTrialPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenTrialPackageResponse
        /// </returns>
        public async Task<OpenTrialPackageResponse> OpenTrialPackageAsync(OpenTrialPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenTrialPackageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账号安全事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountSafetyIncidentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountSafetyIncidentResponse
        /// </returns>
        public QueryAccountSafetyIncidentResponse QueryAccountSafetyIncidentWithOptions(QueryAccountSafetyIncidentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["AliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseCode))
            {
                query["CaseCode"] = request.CaseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishEndTime))
            {
                query["PunishEndTime"] = request.PunishEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishStartTime))
            {
                query["PunishStartTime"] = request.PunishStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountSafetyIncident",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountSafetyIncidentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账号安全事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountSafetyIncidentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountSafetyIncidentResponse
        /// </returns>
        public async Task<QueryAccountSafetyIncidentResponse> QueryAccountSafetyIncidentWithOptionsAsync(QueryAccountSafetyIncidentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["AliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseCode))
            {
                query["CaseCode"] = request.CaseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishEndTime))
            {
                query["PunishEndTime"] = request.PunishEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishStartTime))
            {
                query["PunishStartTime"] = request.PunishStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAccountSafetyIncident",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAccountSafetyIncidentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账号安全事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountSafetyIncidentRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountSafetyIncidentResponse
        /// </returns>
        public QueryAccountSafetyIncidentResponse QueryAccountSafetyIncident(QueryAccountSafetyIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountSafetyIncidentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账号安全事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAccountSafetyIncidentRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAccountSafetyIncidentResponse
        /// </returns>
        public async Task<QueryAccountSafetyIncidentResponse> QueryAccountSafetyIncidentAsync(QueryAccountSafetyIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountSafetyIncidentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云上安全指南的订阅状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGuideSubStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGuideSubStatusResponse
        /// </returns>
        public QueryGuideSubStatusResponse QueryGuideSubStatusWithOptions(QueryGuideSubStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGuideSubStatus",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGuideSubStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云上安全指南的订阅状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGuideSubStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryGuideSubStatusResponse
        /// </returns>
        public async Task<QueryGuideSubStatusResponse> QueryGuideSubStatusWithOptionsAsync(QueryGuideSubStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryGuideSubStatus",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGuideSubStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云上安全指南的订阅状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGuideSubStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGuideSubStatusResponse
        /// </returns>
        public QueryGuideSubStatusResponse QueryGuideSubStatus(QueryGuideSubStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryGuideSubStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云上安全指南的订阅状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryGuideSubStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryGuideSubStatusResponse
        /// </returns>
        public async Task<QueryGuideSubStatusResponse> QueryGuideSubStatusAsync(QueryGuideSubStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryGuideSubStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源管控事件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryResourceControlEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceControlEventsResponse
        /// </returns>
        public QueryResourceControlEventsResponse QueryResourceControlEventsWithOptions(QueryResourceControlEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryResourceControlEventsShrinkRequest request = new QueryResourceControlEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionCodes))
            {
                request.ActionCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionCodes, "ActionCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseCodesPrefix))
            {
                request.CaseCodesPrefixShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseCodesPrefix, "CaseCodesPrefix", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventCodes))
            {
                request.EventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventCodes, "EventCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventIdList))
            {
                request.EventIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventIdList, "EventIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeActionCodes))
            {
                request.ExcludeActionCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeActionCodes, "ExcludeActionCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeEventCodes))
            {
                request.ExcludeEventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeEventCodes, "ExcludeEventCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeReasons))
            {
                request.ExcludeReasonsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeReasons, "ExcludeReasons", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncludeReasons))
            {
                request.IncludeReasonsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncludeReasons, "IncludeReasons", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceCodes))
            {
                request.SourceCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceCodes, "SourceCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "StatusList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCode))
            {
                query["ActionCode"] = request.ActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodesShrink))
            {
                query["ActionCodes"] = request.ActionCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["AliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessCode))
            {
                query["BusinessCode"] = request.BusinessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseCodesPrefixShrink))
            {
                query["CaseCodesPrefix"] = request.CaseCodesPrefixShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventCode))
            {
                query["EventCode"] = request.EventCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventCodesShrink))
            {
                query["EventCodes"] = request.EventCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventIdListShrink))
            {
                query["EventIdList"] = request.EventIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeActionCodesShrink))
            {
                query["ExcludeActionCodes"] = request.ExcludeActionCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeEventCodesShrink))
            {
                query["ExcludeEventCodes"] = request.ExcludeEventCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeReasonsShrink))
            {
                query["ExcludeReasons"] = request.ExcludeReasonsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeReasonsShrink))
            {
                query["IncludeReasons"] = request.IncludeReasonsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishEndTime))
            {
                query["PunishEndTime"] = request.PunishEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishStartTime))
            {
                query["PunishStartTime"] = request.PunishStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCodesShrink))
            {
                query["SourceCodes"] = request.SourceCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["StatusList"] = request.StatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResourceControlEvents",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourceControlEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源管控事件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryResourceControlEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceControlEventsResponse
        /// </returns>
        public async Task<QueryResourceControlEventsResponse> QueryResourceControlEventsWithOptionsAsync(QueryResourceControlEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryResourceControlEventsShrinkRequest request = new QueryResourceControlEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionCodes))
            {
                request.ActionCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionCodes, "ActionCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseCodesPrefix))
            {
                request.CaseCodesPrefixShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseCodesPrefix, "CaseCodesPrefix", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventCodes))
            {
                request.EventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventCodes, "EventCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventIdList))
            {
                request.EventIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventIdList, "EventIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeActionCodes))
            {
                request.ExcludeActionCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeActionCodes, "ExcludeActionCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeEventCodes))
            {
                request.ExcludeEventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeEventCodes, "ExcludeEventCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeReasons))
            {
                request.ExcludeReasonsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeReasons, "ExcludeReasons", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IncludeReasons))
            {
                request.IncludeReasonsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IncludeReasons, "IncludeReasons", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceCodes))
            {
                request.SourceCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceCodes, "SourceCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "StatusList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCode))
            {
                query["ActionCode"] = request.ActionCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodesShrink))
            {
                query["ActionCodes"] = request.ActionCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunLang))
            {
                query["AliyunLang"] = request.AliyunLang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessCode))
            {
                query["BusinessCode"] = request.BusinessCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseCodesPrefixShrink))
            {
                query["CaseCodesPrefix"] = request.CaseCodesPrefixShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                query["Current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventCode))
            {
                query["EventCode"] = request.EventCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventCodesShrink))
            {
                query["EventCodes"] = request.EventCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventIdListShrink))
            {
                query["EventIdList"] = request.EventIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeActionCodesShrink))
            {
                query["ExcludeActionCodes"] = request.ExcludeActionCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeEventCodesShrink))
            {
                query["ExcludeEventCodes"] = request.ExcludeEventCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeReasonsShrink))
            {
                query["ExcludeReasons"] = request.ExcludeReasonsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeReasonsShrink))
            {
                query["IncludeReasons"] = request.IncludeReasonsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishEndTime))
            {
                query["PunishEndTime"] = request.PunishEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishStartTime))
            {
                query["PunishStartTime"] = request.PunishStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCodesShrink))
            {
                query["SourceCodes"] = request.SourceCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["StatusList"] = request.StatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResourceControlEvents",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourceControlEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源管控事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourceControlEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceControlEventsResponse
        /// </returns>
        public QueryResourceControlEventsResponse QueryResourceControlEvents(QueryResourceControlEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryResourceControlEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询云资源管控事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourceControlEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceControlEventsResponse
        /// </returns>
        public async Task<QueryResourceControlEventsResponse> QueryResourceControlEventsAsync(QueryResourceControlEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryResourceControlEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询安全体检简报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySecurityCheckReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySecurityCheckReportResponse
        /// </returns>
        public QuerySecurityCheckReportResponse QuerySecurityCheckReportWithOptions(QuerySecurityCheckReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySecurityCheckReport",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecurityCheckReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询安全体检简报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySecurityCheckReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySecurityCheckReportResponse
        /// </returns>
        public async Task<QuerySecurityCheckReportResponse> QuerySecurityCheckReportWithOptionsAsync(QuerySecurityCheckReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySecurityCheckReport",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySecurityCheckReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询安全体检简报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySecurityCheckReportRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySecurityCheckReportResponse
        /// </returns>
        public QuerySecurityCheckReportResponse QuerySecurityCheckReport(QuerySecurityCheckReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecurityCheckReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询安全体检简报</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QuerySecurityCheckReportRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySecurityCheckReportResponse
        /// </returns>
        public async Task<QuerySecurityCheckReportResponse> QuerySecurityCheckReportAsync(QuerySecurityCheckReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecurityCheckReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启处置工具授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDisposalToolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDisposalToolServiceResponse
        /// </returns>
        public StartDisposalToolServiceResponse StartDisposalToolServiceWithOptions(StartDisposalToolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDisposalToolService",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDisposalToolServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启处置工具授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDisposalToolServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDisposalToolServiceResponse
        /// </returns>
        public async Task<StartDisposalToolServiceResponse> StartDisposalToolServiceWithOptionsAsync(StartDisposalToolServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDisposalToolService",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDisposalToolServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启处置工具授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDisposalToolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDisposalToolServiceResponse
        /// </returns>
        public StartDisposalToolServiceResponse StartDisposalToolService(StartDisposalToolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDisposalToolServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启处置工具授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartDisposalToolServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDisposalToolServiceResponse
        /// </returns>
        public async Task<StartDisposalToolServiceResponse> StartDisposalToolServiceAsync(StartDisposalToolServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDisposalToolServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启安全体检</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartSecurityCheckServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartSecurityCheckServiceResponse
        /// </returns>
        public StartSecurityCheckServiceResponse StartSecurityCheckServiceWithOptions(StartSecurityCheckServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSecurityCheckService",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSecurityCheckServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启安全体检</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartSecurityCheckServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartSecurityCheckServiceResponse
        /// </returns>
        public async Task<StartSecurityCheckServiceResponse> StartSecurityCheckServiceWithOptionsAsync(StartSecurityCheckServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartSecurityCheckService",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartSecurityCheckServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启安全体检</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartSecurityCheckServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartSecurityCheckServiceResponse
        /// </returns>
        public StartSecurityCheckServiceResponse StartSecurityCheckService(StartSecurityCheckServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartSecurityCheckServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开启安全体检</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartSecurityCheckServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartSecurityCheckServiceResponse
        /// </returns>
        public async Task<StartSecurityCheckServiceResponse> StartSecurityCheckServiceAsync(StartSecurityCheckServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartSecurityCheckServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请解封</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitApplyRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitApplyRecordResponse
        /// </returns>
        public SubmitApplyRecordResponse SubmitApplyRecordWithOptions(SubmitApplyRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitApplyRecordShrinkRequest request = new SubmitApplyRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventIdList))
            {
                request.EventIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventIdList, "EventIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRequest))
            {
                query["ApplyRequest"] = request.ApplyRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitmentLetter))
            {
                query["CommitmentLetter"] = request.CommitmentLetter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventIdListShrink))
            {
                query["EventIdList"] = request.EventIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationProof))
            {
                query["QualificationProof"] = request.QualificationProof;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trial))
            {
                query["Trial"] = request.Trial;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitApplyRecord",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitApplyRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请解封</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SubmitApplyRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitApplyRecordResponse
        /// </returns>
        public async Task<SubmitApplyRecordResponse> SubmitApplyRecordWithOptionsAsync(SubmitApplyRecordRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SubmitApplyRecordShrinkRequest request = new SubmitApplyRecordShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventIdList))
            {
                request.EventIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventIdList, "EventIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyRequest))
            {
                query["ApplyRequest"] = request.ApplyRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommitmentLetter))
            {
                query["CommitmentLetter"] = request.CommitmentLetter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventIdListShrink))
            {
                query["EventIdList"] = request.EventIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationProof))
            {
                query["QualificationProof"] = request.QualificationProof;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Trial))
            {
                query["Trial"] = request.Trial;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitApplyRecord",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitApplyRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请解封</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitApplyRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitApplyRecordResponse
        /// </returns>
        public SubmitApplyRecordResponse SubmitApplyRecord(SubmitApplyRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitApplyRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请解封</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitApplyRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitApplyRecordResponse
        /// </returns>
        public async Task<SubmitApplyRecordResponse> SubmitApplyRecordAsync(SubmitApplyRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitApplyRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-更新后付费绑定关系</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePostPaidBindRelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePostPaidBindRelResponse
        /// </returns>
        public UpdatePostPaidBindRelResponse UpdatePostPaidBindRelWithOptions(UpdatePostPaidBindRelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePostPaidBindRelShrinkRequest request = new UpdatePostPaidBindRelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePostPaidBindRel",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePostPaidBindRelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-更新后付费绑定关系</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePostPaidBindRelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePostPaidBindRelResponse
        /// </returns>
        public async Task<UpdatePostPaidBindRelResponse> UpdatePostPaidBindRelWithOptionsAsync(UpdatePostPaidBindRelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePostPaidBindRelShrinkRequest request = new UpdatePostPaidBindRelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SdkRequest))
            {
                request.SdkRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SdkRequest, "SdkRequest", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SdkRequestShrink))
            {
                query["SdkRequest"] = request.SdkRequestShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePostPaidBindRel",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePostPaidBindRelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-更新后付费绑定关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePostPaidBindRelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePostPaidBindRelResponse
        /// </returns>
        public UpdatePostPaidBindRelResponse UpdatePostPaidBindRel(UpdatePostPaidBindRelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePostPaidBindRelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>sas-更新后付费绑定关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePostPaidBindRelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePostPaidBindRelResponse
        /// </returns>
        public async Task<UpdatePostPaidBindRelResponse> UpdatePostPaidBindRelAsync(UpdatePostPaidBindRelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePostPaidBindRelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新体检结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecurityCheckResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityCheckResultResponse
        /// </returns>
        public UpdateSecurityCheckResultResponse UpdateSecurityCheckResultWithOptions(UpdateSecurityCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecurityCheckResult",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecurityCheckResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新体检结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecurityCheckResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityCheckResultResponse
        /// </returns>
        public async Task<UpdateSecurityCheckResultResponse> UpdateSecurityCheckResultWithOptionsAsync(UpdateSecurityCheckResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecurityCheckResult",
                Version = "2026-04-24",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecurityCheckResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新体检结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecurityCheckResultRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityCheckResultResponse
        /// </returns>
        public UpdateSecurityCheckResultResponse UpdateSecurityCheckResult(UpdateSecurityCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecurityCheckResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新体检结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecurityCheckResultRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityCheckResultResponse
        /// </returns>
        public async Task<UpdateSecurityCheckResultResponse> UpdateSecurityCheckResultAsync(UpdateSecurityCheckResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecurityCheckResultWithOptionsAsync(request, runtime);
        }

    }
}
