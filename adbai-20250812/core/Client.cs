// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ADBAI20250812.Models;

namespace AlibabaCloud.SDK.ADBAI20250812
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("adbai", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建指标平台</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentPlatformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentPlatformResponse
        /// </returns>
        public CreateAgentPlatformResponse CreateAgentPlatformWithOptions(CreateAgentPlatformRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentPlatformShrinkRequest request = new CreateAgentPlatformShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AiPlatformConfig))
            {
                request.AiPlatformConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AiPlatformConfig, "AiPlatformConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiPlatformConfigShrink))
            {
                query["AiPlatformConfig"] = request.AiPlatformConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "CreateAgentPlatform",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentPlatformResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建指标平台</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAgentPlatformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentPlatformResponse
        /// </returns>
        public async Task<CreateAgentPlatformResponse> CreateAgentPlatformWithOptionsAsync(CreateAgentPlatformRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAgentPlatformShrinkRequest request = new CreateAgentPlatformShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AiPlatformConfig))
            {
                request.AiPlatformConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AiPlatformConfig, "AiPlatformConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AiPlatformConfigShrink))
            {
                query["AiPlatformConfig"] = request.AiPlatformConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "CreateAgentPlatform",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentPlatformResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建指标平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentPlatformRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentPlatformResponse
        /// </returns>
        public CreateAgentPlatformResponse CreateAgentPlatform(CreateAgentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentPlatformWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建指标平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentPlatformRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentPlatformResponse
        /// </returns>
        public async Task<CreateAgentPlatformResponse> CreateAgentPlatformAsync(CreateAgentPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentPlatformWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEmbodiedAIPlatformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEmbodiedAIPlatformResponse
        /// </returns>
        public CreateEmbodiedAIPlatformResponse CreateEmbodiedAIPlatformWithOptions(CreateEmbodiedAIPlatformRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEmbodiedAIPlatformShrinkRequest request = new CreateEmbodiedAIPlatformShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RayConfig))
            {
                request.RayConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RayConfig, "RayConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RayConfigShrink))
            {
                query["RayConfig"] = request.RayConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebserverSpecName))
            {
                query["WebserverSpecName"] = request.WebserverSpecName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEmbodiedAIPlatform",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEmbodiedAIPlatformResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateEmbodiedAIPlatformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEmbodiedAIPlatformResponse
        /// </returns>
        public async Task<CreateEmbodiedAIPlatformResponse> CreateEmbodiedAIPlatformWithOptionsAsync(CreateEmbodiedAIPlatformRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEmbodiedAIPlatformShrinkRequest request = new CreateEmbodiedAIPlatformShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RayConfig))
            {
                request.RayConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RayConfig, "RayConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RayConfigShrink))
            {
                query["RayConfig"] = request.RayConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebserverSpecName))
            {
                query["WebserverSpecName"] = request.WebserverSpecName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEmbodiedAIPlatform",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEmbodiedAIPlatformResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEmbodiedAIPlatformRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEmbodiedAIPlatformResponse
        /// </returns>
        public CreateEmbodiedAIPlatformResponse CreateEmbodiedAIPlatform(CreateEmbodiedAIPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEmbodiedAIPlatformWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateEmbodiedAIPlatformRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEmbodiedAIPlatformResponse
        /// </returns>
        public async Task<CreateEmbodiedAIPlatformResponse> CreateEmbodiedAIPlatformAsync(CreateEmbodiedAIPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEmbodiedAIPlatformWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEmbodiedAIPlatformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmbodiedAIPlatformResponse
        /// </returns>
        public DeleteEmbodiedAIPlatformResponse DeleteEmbodiedAIPlatformWithOptions(DeleteEmbodiedAIPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
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
                Action = "DeleteEmbodiedAIPlatform",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEmbodiedAIPlatformResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEmbodiedAIPlatformRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmbodiedAIPlatformResponse
        /// </returns>
        public async Task<DeleteEmbodiedAIPlatformResponse> DeleteEmbodiedAIPlatformWithOptionsAsync(DeleteEmbodiedAIPlatformRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
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
                Action = "DeleteEmbodiedAIPlatform",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEmbodiedAIPlatformResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEmbodiedAIPlatformRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmbodiedAIPlatformResponse
        /// </returns>
        public DeleteEmbodiedAIPlatformResponse DeleteEmbodiedAIPlatform(DeleteEmbodiedAIPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEmbodiedAIPlatformWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEmbodiedAIPlatformRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmbodiedAIPlatformResponse
        /// </returns>
        public async Task<DeleteEmbodiedAIPlatformResponse> DeleteEmbodiedAIPlatformAsync(DeleteEmbodiedAIPlatformRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEmbodiedAIPlatformWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEmbodiedAIPlatformsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmbodiedAIPlatformsResponse
        /// </returns>
        public DescribeEmbodiedAIPlatformsResponse DescribeEmbodiedAIPlatformsWithOptions(DescribeEmbodiedAIPlatformsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmbodiedAIPlatforms",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmbodiedAIPlatformsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEmbodiedAIPlatformsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmbodiedAIPlatformsResponse
        /// </returns>
        public async Task<DescribeEmbodiedAIPlatformsResponse> DescribeEmbodiedAIPlatformsWithOptionsAsync(DescribeEmbodiedAIPlatformsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmbodiedAIPlatforms",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmbodiedAIPlatformsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEmbodiedAIPlatformsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmbodiedAIPlatformsResponse
        /// </returns>
        public DescribeEmbodiedAIPlatformsResponse DescribeEmbodiedAIPlatforms(DescribeEmbodiedAIPlatformsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEmbodiedAIPlatformsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEmbodiedAIPlatformsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEmbodiedAIPlatformsResponse
        /// </returns>
        public async Task<DescribeEmbodiedAIPlatformsResponse> DescribeEmbodiedAIPlatformsAsync(DescribeEmbodiedAIPlatformsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEmbodiedAIPlatformsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台资源用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmbodiedAIPlatformResourceUsageInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmbodiedAIPlatformResourceUsageInfoResponse
        /// </returns>
        public GetEmbodiedAIPlatformResourceUsageInfoResponse GetEmbodiedAIPlatformResourceUsageInfoWithOptions(GetEmbodiedAIPlatformResourceUsageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "GetEmbodiedAIPlatformResourceUsageInfo",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmbodiedAIPlatformResourceUsageInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台资源用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmbodiedAIPlatformResourceUsageInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEmbodiedAIPlatformResourceUsageInfoResponse
        /// </returns>
        public async Task<GetEmbodiedAIPlatformResourceUsageInfoResponse> GetEmbodiedAIPlatformResourceUsageInfoWithOptionsAsync(GetEmbodiedAIPlatformResourceUsageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "GetEmbodiedAIPlatformResourceUsageInfo",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmbodiedAIPlatformResourceUsageInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台资源用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmbodiedAIPlatformResourceUsageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEmbodiedAIPlatformResourceUsageInfoResponse
        /// </returns>
        public GetEmbodiedAIPlatformResourceUsageInfoResponse GetEmbodiedAIPlatformResourceUsageInfo(GetEmbodiedAIPlatformResourceUsageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEmbodiedAIPlatformResourceUsageInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询具身智能平台资源用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEmbodiedAIPlatformResourceUsageInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEmbodiedAIPlatformResourceUsageInfoResponse
        /// </returns>
        public async Task<GetEmbodiedAIPlatformResourceUsageInfoResponse> GetEmbodiedAIPlatformResourceUsageInfoAsync(GetEmbodiedAIPlatformResourceUsageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEmbodiedAIPlatformResourceUsageInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置具身智能平台密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetEmbodiedAIPlatformPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetEmbodiedAIPlatformPasswordResponse
        /// </returns>
        public ResetEmbodiedAIPlatformPasswordResponse ResetEmbodiedAIPlatformPasswordWithOptions(ResetEmbodiedAIPlatformPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
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
                Action = "ResetEmbodiedAIPlatformPassword",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetEmbodiedAIPlatformPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置具身智能平台密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetEmbodiedAIPlatformPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetEmbodiedAIPlatformPasswordResponse
        /// </returns>
        public async Task<ResetEmbodiedAIPlatformPasswordResponse> ResetEmbodiedAIPlatformPasswordWithOptionsAsync(ResetEmbodiedAIPlatformPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBClusterId))
            {
                query["DBClusterId"] = request.DBClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformName))
            {
                query["PlatformName"] = request.PlatformName;
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
                Action = "ResetEmbodiedAIPlatformPassword",
                Version = "2025-08-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetEmbodiedAIPlatformPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置具身智能平台密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetEmbodiedAIPlatformPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetEmbodiedAIPlatformPasswordResponse
        /// </returns>
        public ResetEmbodiedAIPlatformPasswordResponse ResetEmbodiedAIPlatformPassword(ResetEmbodiedAIPlatformPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetEmbodiedAIPlatformPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置具身智能平台密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetEmbodiedAIPlatformPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetEmbodiedAIPlatformPasswordResponse
        /// </returns>
        public async Task<ResetEmbodiedAIPlatformPasswordResponse> ResetEmbodiedAIPlatformPasswordAsync(ResetEmbodiedAIPlatformPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetEmbodiedAIPlatformPasswordWithOptionsAsync(request, runtime);
        }

    }
}
