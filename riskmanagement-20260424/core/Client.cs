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
            this._endpointRule = "";
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

    }
}
