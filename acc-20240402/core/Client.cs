// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Acc20240402.Models;

namespace AlibabaCloud.SDK.Acc20240402
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "acc.aliyuncs.com"},
                {"ap-south-1", "acc.aliyuncs.com"},
                {"ap-southeast-2", "acc.aliyuncs.com"},
                {"cn-beijing-finance-1", "acc.aliyuncs.com"},
                {"cn-beijing-finance-pop", "acc.aliyuncs.com"},
                {"cn-beijing-gov-1", "acc.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "acc.aliyuncs.com"},
                {"cn-edge-1", "acc.aliyuncs.com"},
                {"cn-fujian", "acc.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "acc.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "acc.aliyuncs.com"},
                {"cn-hangzhou-finance", "acc.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "acc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "acc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "acc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "acc.aliyuncs.com"},
                {"cn-hangzhou-test-306", "acc.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "acc.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "acc.aliyuncs.com"},
                {"cn-qingdao-nebula", "acc.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "acc.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "acc.aliyuncs.com"},
                {"cn-shanghai-inner", "acc.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "acc.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "acc.aliyuncs.com"},
                {"cn-shenzhen-inner", "acc.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "acc.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "acc.aliyuncs.com"},
                {"cn-wuhan", "acc.aliyuncs.com"},
                {"cn-yushanfang", "acc.aliyuncs.com"},
                {"cn-zhangbei", "acc.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "acc.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "acc.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "acc.aliyuncs.com"},
                {"eu-west-1-oxs", "acc.aliyuncs.com"},
                {"rus-west-1-pop", "acc.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("acc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>创建镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageCacheResponse
        /// </returns>
        public CreateImageCacheResponse CreateImageCacheWithOptions(CreateImageCacheRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageCacheShrinkRequest request = new CreateImageCacheShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkConfig))
            {
                request.NetworkConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkConfig, "NetworkConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfos))
            {
                query["AcrRegistryInfos"] = request.AcrRegistryInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredentials))
            {
                query["ImageRegistryCredentials"] = request.ImageRegistryCredentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkConfigShrink))
            {
                query["NetworkConfig"] = request.NetworkConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageCache",
                Version = "2024-04-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageCacheResponse
        /// </returns>
        public async Task<CreateImageCacheResponse> CreateImageCacheWithOptionsAsync(CreateImageCacheRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateImageCacheShrinkRequest request = new CreateImageCacheShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkConfig))
            {
                request.NetworkConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkConfig, "NetworkConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfos))
            {
                query["AcrRegistryInfos"] = request.AcrRegistryInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredentials))
            {
                query["ImageRegistryCredentials"] = request.ImageRegistryCredentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Images))
            {
                query["Images"] = request.Images;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkConfigShrink))
            {
                query["NetworkConfig"] = request.NetworkConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateImageCache",
                Version = "2024-04-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageCacheResponse
        /// </returns>
        public CreateImageCacheResponse CreateImageCache(CreateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageCacheResponse
        /// </returns>
        public async Task<CreateImageCacheResponse> CreateImageCacheAsync(CreateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageCacheResponse
        /// </returns>
        public DeleteImageCacheResponse DeleteImageCacheWithOptions(DeleteImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
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
                Action = "DeleteImageCache",
                Version = "2024-04-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageCacheResponse
        /// </returns>
        public async Task<DeleteImageCacheResponse> DeleteImageCacheWithOptionsAsync(DeleteImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
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
                Action = "DeleteImageCache",
                Version = "2024-04-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageCacheResponse
        /// </returns>
        public DeleteImageCacheResponse DeleteImageCache(DeleteImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageCacheResponse
        /// </returns>
        public async Task<DeleteImageCacheResponse> DeleteImageCacheAsync(DeleteImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageCacheResponse
        /// </returns>
        public GetImageCacheResponse GetImageCacheWithOptions(GetImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
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
                Action = "GetImageCache",
                Version = "2024-04-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetImageCacheResponse
        /// </returns>
        public async Task<GetImageCacheResponse> GetImageCacheWithOptionsAsync(GetImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
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
                Action = "GetImageCache",
                Version = "2024-04-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetImageCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageCacheResponse
        /// </returns>
        public GetImageCacheResponse GetImageCache(GetImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// GetImageCacheResponse
        /// </returns>
        public async Task<GetImageCacheResponse> GetImageCacheAsync(GetImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImageCachesResponse
        /// </returns>
        public ListImageCachesResponse ListImageCachesWithOptions(ListImageCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImageCaches",
                Version = "2024-04-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageCachesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImageCachesResponse
        /// </returns>
        public async Task<ListImageCachesResponse> ListImageCachesWithOptionsAsync(ListImageCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListImageCaches",
                Version = "2024-04-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListImageCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImageCachesResponse
        /// </returns>
        public ListImageCachesResponse ListImageCaches(ListImageCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImageCachesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询镜像缓存</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListImageCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImageCachesResponse
        /// </returns>
        public async Task<ListImageCachesResponse> ListImageCachesAsync(ListImageCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImageCachesWithOptionsAsync(request, runtime);
        }

    }
}
