// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Kvcachestore20260617.Models;

namespace AlibabaCloud.SDK.Kvcachestore20260617
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "kvcachestore.cn-beijing.aliyuncs.com"},
                {"cn-shanghai", "kvcachestore.cn-shanghai.aliyuncs.com"},
                {"ap-southeast-1", "kvcachestore.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("kvcachestore", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Mounts KVCacheInstance resources to the virtualization side in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. A return status of Attaching indicates that the request has been accepted. Call ListKVCacheStoreAttachInfo to query mount records. A record status of Attached indicates that the mount is complete.</para>
        /// <list type="bullet">
        /// <item><description>The KVCacheStore must be in the Available or InUse state before it can be mounted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachKVCacheStoreResponse
        /// </returns>
        public AttachKVCacheStoreResponse AttachKVCacheStoreWithOptions(AttachKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arns))
            {
                query["Arns"] = request.Arns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachKVCacheStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mounts KVCacheInstance resources to the virtualization side in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. A return status of Attaching indicates that the request has been accepted. Call ListKVCacheStoreAttachInfo to query mount records. A record status of Attached indicates that the mount is complete.</para>
        /// <list type="bullet">
        /// <item><description>The KVCacheStore must be in the Available or InUse state before it can be mounted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachKVCacheStoreResponse
        /// </returns>
        public async Task<AttachKVCacheStoreResponse> AttachKVCacheStoreWithOptionsAsync(AttachKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arns))
            {
                query["Arns"] = request.Arns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachKVCacheStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mounts KVCacheInstance resources to the virtualization side in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. A return status of Attaching indicates that the request has been accepted. Call ListKVCacheStoreAttachInfo to query mount records. A record status of Attached indicates that the mount is complete.</para>
        /// <list type="bullet">
        /// <item><description>The KVCacheStore must be in the Available or InUse state before it can be mounted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachKVCacheStoreResponse
        /// </returns>
        public AttachKVCacheStoreResponse AttachKVCacheStore(AttachKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachKVCacheStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Mounts KVCacheInstance resources to the virtualization side in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. A return status of Attaching indicates that the request has been accepted. Call ListKVCacheStoreAttachInfo to query mount records. A record status of Attached indicates that the mount is complete.</para>
        /// <list type="bullet">
        /// <item><description>The KVCacheStore must be in the Available or InUse state before it can be mounted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachKVCacheStoreResponse
        /// </returns>
        public async Task<AttachKVCacheStoreResponse> AttachKVCacheStoreAsync(AttachKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachKVCacheStoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a KVCacheInstance instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. After the request is successful, the KVCacheStore enters the Creating state. You can call GetKVCacheStore or ListKVCacheStores to query the KVCacheStore status. The KVCacheStore becomes available when its status changes to Available.</para>
        /// <list type="bullet">
        /// <item><description>To ensure idempotence in case of network exceptions, use ClientToken. If you call the operation with the same ClientToken and the same request parameters, the same KVCacheStore ID and order ID are returned. If the request parameters change, an IdempotentParameterMismatch error is returned.</description></item>
        /// <item><description>Creating a KVCacheStore generates an order. The response includes OrderId, which you can view in the Expenses and Costs console. For more information, refer to View and manage orders.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKVCacheStoreResponse
        /// </returns>
        public CreateKVCacheStoreResponse CreateKVCacheStoreWithOptions(CreateKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpnZone))
            {
                query["HpnZone"] = request.HpnZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "CreateKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKVCacheStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a KVCacheInstance instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. After the request is successful, the KVCacheStore enters the Creating state. You can call GetKVCacheStore or ListKVCacheStores to query the KVCacheStore status. The KVCacheStore becomes available when its status changes to Available.</para>
        /// <list type="bullet">
        /// <item><description>To ensure idempotence in case of network exceptions, use ClientToken. If you call the operation with the same ClientToken and the same request parameters, the same KVCacheStore ID and order ID are returned. If the request parameters change, an IdempotentParameterMismatch error is returned.</description></item>
        /// <item><description>Creating a KVCacheStore generates an order. The response includes OrderId, which you can view in the Expenses and Costs console. For more information, refer to View and manage orders.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKVCacheStoreResponse
        /// </returns>
        public async Task<CreateKVCacheStoreResponse> CreateKVCacheStoreWithOptionsAsync(CreateKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HpnZone))
            {
                query["HpnZone"] = request.HpnZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "CreateKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKVCacheStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a KVCacheInstance instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. After the request is successful, the KVCacheStore enters the Creating state. You can call GetKVCacheStore or ListKVCacheStores to query the KVCacheStore status. The KVCacheStore becomes available when its status changes to Available.</para>
        /// <list type="bullet">
        /// <item><description>To ensure idempotence in case of network exceptions, use ClientToken. If you call the operation with the same ClientToken and the same request parameters, the same KVCacheStore ID and order ID are returned. If the request parameters change, an IdempotentParameterMismatch error is returned.</description></item>
        /// <item><description>Creating a KVCacheStore generates an order. The response includes OrderId, which you can view in the Expenses and Costs console. For more information, refer to View and manage orders.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKVCacheStoreResponse
        /// </returns>
        public CreateKVCacheStoreResponse CreateKVCacheStore(CreateKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKVCacheStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a KVCacheInstance instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. After the request is successful, the KVCacheStore enters the Creating state. You can call GetKVCacheStore or ListKVCacheStores to query the KVCacheStore status. The KVCacheStore becomes available when its status changes to Available.</para>
        /// <list type="bullet">
        /// <item><description>To ensure idempotence in case of network exceptions, use ClientToken. If you call the operation with the same ClientToken and the same request parameters, the same KVCacheStore ID and order ID are returned. If the request parameters change, an IdempotentParameterMismatch error is returned.</description></item>
        /// <item><description>Creating a KVCacheStore generates an order. The response includes OrderId, which you can view in the Expenses and Costs console. For more information, refer to View and manage orders.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKVCacheStoreResponse
        /// </returns>
        public async Task<CreateKVCacheStoreResponse> CreateKVCacheStoreAsync(CreateKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKVCacheStoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a KVCacheInstance instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The delete operation is irreversible. Data in the KVCacheStore will be erased and cannot be recovered. Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description>Billing stops after the deletion begins.</description></item>
        /// <item><description>The KVCacheStore to be deleted cannot be in the Creating state.</description></item>
        /// <item><description>The KVCacheStore to be deleted cannot have mount records in the Attaching or Attached state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKVCacheStoreResponse
        /// </returns>
        public DeleteKVCacheStoreResponse DeleteKVCacheStoreWithOptions(DeleteKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsId))
            {
                query["KvcsId"] = request.KvcsId;
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
                Action = "DeleteKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKVCacheStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a KVCacheInstance instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The delete operation is irreversible. Data in the KVCacheStore will be erased and cannot be recovered. Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description>Billing stops after the deletion begins.</description></item>
        /// <item><description>The KVCacheStore to be deleted cannot be in the Creating state.</description></item>
        /// <item><description>The KVCacheStore to be deleted cannot have mount records in the Attaching or Attached state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKVCacheStoreResponse
        /// </returns>
        public async Task<DeleteKVCacheStoreResponse> DeleteKVCacheStoreWithOptionsAsync(DeleteKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsId))
            {
                query["KvcsId"] = request.KvcsId;
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
                Action = "DeleteKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteKVCacheStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a KVCacheInstance instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The delete operation is irreversible. Data in the KVCacheStore will be erased and cannot be recovered. Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description>Billing stops after the deletion begins.</description></item>
        /// <item><description>The KVCacheStore to be deleted cannot be in the Creating state.</description></item>
        /// <item><description>The KVCacheStore to be deleted cannot have mount records in the Attaching or Attached state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKVCacheStoreResponse
        /// </returns>
        public DeleteKVCacheStoreResponse DeleteKVCacheStore(DeleteKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKVCacheStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a KVCacheInstance instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The delete operation is irreversible. Data in the KVCacheStore will be erased and cannot be recovered. Proceed with caution.</para>
        /// <list type="bullet">
        /// <item><description>Billing stops after the deletion begins.</description></item>
        /// <item><description>The KVCacheStore to be deleted cannot be in the Creating state.</description></item>
        /// <item><description>The KVCacheStore to be deleted cannot have mount records in the Attaching or Attached state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKVCacheStoreResponse
        /// </returns>
        public async Task<DeleteKVCacheStoreResponse> DeleteKVCacheStoreAsync(DeleteKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKVCacheStoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of regions where KVCacheStore is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRegions",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of regions where KVCacheStore is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeRegions",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of regions where KVCacheStore is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of regions where KVCacheStore is activated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available zones for KVCacheStore in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeZones",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available zones for KVCacheStore in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeZones",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available zones for KVCacheStore in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of available zones for KVCacheStore in a specified region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeZonesResponse
        /// </returns>
        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unmounts KVCacheInstance resources from the virtualization side in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. A return status of Detaching indicates that the request has been accepted. Call ListKVCacheStoreAttachInfo to query mount records. When no record corresponding to the specified KvcsId and VscId is found, the unmount operation is complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachKVCacheStoreResponse
        /// </returns>
        public DetachKVCacheStoreResponse DetachKVCacheStoreWithOptions(DetachKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachKVCacheStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unmounts KVCacheInstance resources from the virtualization side in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. A return status of Detaching indicates that the request has been accepted. Call ListKVCacheStoreAttachInfo to query mount records. When no record corresponding to the specified KvcsId and VscId is found, the unmount operation is complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachKVCacheStoreResponse
        /// </returns>
        public async Task<DetachKVCacheStoreResponse> DetachKVCacheStoreWithOptionsAsync(DetachKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachKVCacheStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unmounts KVCacheInstance resources from the virtualization side in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. A return status of Detaching indicates that the request has been accepted. Call ListKVCacheStoreAttachInfo to query mount records. When no record corresponding to the specified KvcsId and VscId is found, the unmount operation is complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachKVCacheStoreResponse
        /// </returns>
        public DetachKVCacheStoreResponse DetachKVCacheStore(DetachKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachKVCacheStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unmounts KVCacheInstance resources from the virtualization side in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is an asynchronous operation. A return status of Detaching indicates that the request has been accepted. Call ListKVCacheStoreAttachInfo to query mount records. When no record corresponding to the specified KvcsId and VscId is found, the unmount operation is complete.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachKVCacheStoreResponse
        /// </returns>
        public async Task<DetachKVCacheStoreResponse> DetachKVCacheStoreAsync(DetachKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachKVCacheStoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 KvCacheStore 实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKVCacheStoreResponse
        /// </returns>
        public GetKVCacheStoreResponse GetKVCacheStoreWithOptions(GetKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsId))
            {
                query["KvcsId"] = request.KvcsId;
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
                Action = "GetKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKVCacheStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 KvCacheStore 实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKVCacheStoreResponse
        /// </returns>
        public async Task<GetKVCacheStoreResponse> GetKVCacheStoreWithOptionsAsync(GetKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsId))
            {
                query["KvcsId"] = request.KvcsId;
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
                Action = "GetKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKVCacheStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 KvCacheStore 实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKVCacheStoreResponse
        /// </returns>
        public GetKVCacheStoreResponse GetKVCacheStore(GetKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKVCacheStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询 KvCacheStore 实例详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKVCacheStoreResponse
        /// </returns>
        public async Task<GetKVCacheStoreResponse> GetKVCacheStoreAsync(GetKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKVCacheStoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mount information of KVCacheInstance resources in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKVCacheStoreAttachInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoreAttachInfoResponse
        /// </returns>
        public ListKVCacheStoreAttachInfoResponse ListKVCacheStoreAttachInfoWithOptions(ListKVCacheStoreAttachInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsIds))
            {
                query["KvcsIds"] = request.KvcsIds;
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
                Action = "ListKVCacheStoreAttachInfo",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKVCacheStoreAttachInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mount information of KVCacheInstance resources in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKVCacheStoreAttachInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoreAttachInfoResponse
        /// </returns>
        public async Task<ListKVCacheStoreAttachInfoResponse> ListKVCacheStoreAttachInfoWithOptionsAsync(ListKVCacheStoreAttachInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsIds))
            {
                query["KvcsIds"] = request.KvcsIds;
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
                Action = "ListKVCacheStoreAttachInfo",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKVCacheStoreAttachInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mount information of KVCacheInstance resources in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKVCacheStoreAttachInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoreAttachInfoResponse
        /// </returns>
        public ListKVCacheStoreAttachInfoResponse ListKVCacheStoreAttachInfo(ListKVCacheStoreAttachInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKVCacheStoreAttachInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mount information of KVCacheInstance resources in batches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKVCacheStoreAttachInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoreAttachInfoResponse
        /// </returns>
        public async Task<ListKVCacheStoreAttachInfoResponse> ListKVCacheStoreAttachInfoAsync(ListKVCacheStoreAttachInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKVCacheStoreAttachInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定 KVCacheStore 实例可用的 HpnZone 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKVCacheStoreAvailableHpnZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoreAvailableHpnZonesResponse
        /// </returns>
        public ListKVCacheStoreAvailableHpnZonesResponse ListKVCacheStoreAvailableHpnZonesWithOptions(ListKVCacheStoreAvailableHpnZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsIds))
            {
                query["KvcsIds"] = request.KvcsIds;
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
                Action = "ListKVCacheStoreAvailableHpnZones",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKVCacheStoreAvailableHpnZonesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定 KVCacheStore 实例可用的 HpnZone 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKVCacheStoreAvailableHpnZonesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoreAvailableHpnZonesResponse
        /// </returns>
        public async Task<ListKVCacheStoreAvailableHpnZonesResponse> ListKVCacheStoreAvailableHpnZonesWithOptionsAsync(ListKVCacheStoreAvailableHpnZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsIds))
            {
                query["KvcsIds"] = request.KvcsIds;
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
                Action = "ListKVCacheStoreAvailableHpnZones",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKVCacheStoreAvailableHpnZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定 KVCacheStore 实例可用的 HpnZone 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKVCacheStoreAvailableHpnZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoreAvailableHpnZonesResponse
        /// </returns>
        public ListKVCacheStoreAvailableHpnZonesResponse ListKVCacheStoreAvailableHpnZones(ListKVCacheStoreAvailableHpnZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKVCacheStoreAvailableHpnZonesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询指定 KVCacheStore 实例可用的 HpnZone 列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKVCacheStoreAvailableHpnZonesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoreAvailableHpnZonesResponse
        /// </returns>
        public async Task<ListKVCacheStoreAvailableHpnZonesResponse> ListKVCacheStoreAvailableHpnZonesAsync(ListKVCacheStoreAvailableHpnZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKVCacheStoreAvailableHpnZonesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of KVCacheInstance instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Two pagination methods are supported: page number-based pagination (PageNumber + PageSize) and cursor-based pagination (NextToken + MaxResults). If both are specified, page number-based pagination takes precedence.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKVCacheStoresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoresResponse
        /// </returns>
        public ListKVCacheStoresResponse ListKVCacheStoresWithOptions(ListKVCacheStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsIds))
            {
                query["KvcsIds"] = request.KvcsIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListKVCacheStores",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKVCacheStoresResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of KVCacheInstance instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Two pagination methods are supported: page number-based pagination (PageNumber + PageSize) and cursor-based pagination (NextToken + MaxResults). If both are specified, page number-based pagination takes precedence.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKVCacheStoresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoresResponse
        /// </returns>
        public async Task<ListKVCacheStoresResponse> ListKVCacheStoresWithOptionsAsync(ListKVCacheStoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsIds))
            {
                query["KvcsIds"] = request.KvcsIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListKVCacheStores",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKVCacheStoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of KVCacheInstance instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Two pagination methods are supported: page number-based pagination (PageNumber + PageSize) and cursor-based pagination (NextToken + MaxResults). If both are specified, page number-based pagination takes precedence.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKVCacheStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoresResponse
        /// </returns>
        public ListKVCacheStoresResponse ListKVCacheStores(ListKVCacheStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKVCacheStoresWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of KVCacheInstance instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Two pagination methods are supported: page number-based pagination (PageNumber + PageSize) and cursor-based pagination (NextToken + MaxResults). If both are specified, page number-based pagination takes precedence.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKVCacheStoresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKVCacheStoresResponse
        /// </returns>
        public async Task<ListKVCacheStoresResponse> ListKVCacheStoresAsync(ListKVCacheStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKVCacheStoresWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a KVCacheStore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Supports modifying Name, Description, and Capacity. The cluster number (HpnZone) cannot be modified after creation.</para>
        /// <list type="bullet">
        /// <item><description>Modifying Capacity triggers a specification change order, and the operation returns an OrderId. Modifying only Name or Description does not generate an order.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKVCacheStoreResponse
        /// </returns>
        public UpdateKVCacheStoreResponse UpdateKVCacheStoreWithOptions(UpdateKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsId))
            {
                query["KvcsId"] = request.KvcsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKVCacheStoreResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a KVCacheStore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Supports modifying Name, Description, and Capacity. The cluster number (HpnZone) cannot be modified after creation.</para>
        /// <list type="bullet">
        /// <item><description>Modifying Capacity triggers a specification change order, and the operation returns an OrderId. Modifying only Name or Description does not generate an order.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKVCacheStoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKVCacheStoreResponse
        /// </returns>
        public async Task<UpdateKVCacheStoreResponse> UpdateKVCacheStoreWithOptionsAsync(UpdateKVCacheStoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                query["Capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KvcsId))
            {
                query["KvcsId"] = request.KvcsId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKVCacheStore",
                Version = "2026-06-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKVCacheStoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a KVCacheStore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Supports modifying Name, Description, and Capacity. The cluster number (HpnZone) cannot be modified after creation.</para>
        /// <list type="bullet">
        /// <item><description>Modifying Capacity triggers a specification change order, and the operation returns an OrderId. Modifying only Name or Description does not generate an order.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKVCacheStoreResponse
        /// </returns>
        public UpdateKVCacheStoreResponse UpdateKVCacheStore(UpdateKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKVCacheStoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the attributes of a KVCacheStore.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Supports modifying Name, Description, and Capacity. The cluster number (HpnZone) cannot be modified after creation.</para>
        /// <list type="bullet">
        /// <item><description>Modifying Capacity triggers a specification change order, and the operation returns an OrderId. Modifying only Name or Description does not generate an order.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKVCacheStoreRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKVCacheStoreResponse
        /// </returns>
        public async Task<UpdateKVCacheStoreResponse> UpdateKVCacheStoreAsync(UpdateKVCacheStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKVCacheStoreWithOptionsAsync(request, runtime);
        }

    }
}
