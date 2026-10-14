// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sddp20260120.Models;

namespace AlibabaCloud.SDK.Sddp20260120
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hongkong", "sddp-api.cn-hongkong.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("sddp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Checks the prerequisites for column encryption on an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Checks the permissions, engine, and runtime conditions of an instance before creating column encryption rules. Check both ErrorCode and ErrorMessage in the response. Only ErrorCode=Success indicates that the check passed. A successful request alone does not mean the instance meets all encryption conditions. This check does not create column encryption rules.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your account.
        /// Use the service registration endpoint of the region where the target asset resides, and configure the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckDataMaskingInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDataMaskingInstanceResponse
        /// </returns>
        public CheckDataMaskingInstanceResponse CheckDataMaskingInstanceWithOptions(CheckDataMaskingInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDataMaskingInstance",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDataMaskingInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the prerequisites for column encryption on an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Checks the permissions, engine, and runtime conditions of an instance before creating column encryption rules. Check both ErrorCode and ErrorMessage in the response. Only ErrorCode=Success indicates that the check passed. A successful request alone does not mean the instance meets all encryption conditions. This check does not create column encryption rules.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your account.
        /// Use the service registration endpoint of the region where the target asset resides, and configure the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckDataMaskingInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDataMaskingInstanceResponse
        /// </returns>
        public async Task<CheckDataMaskingInstanceResponse> CheckDataMaskingInstanceWithOptionsAsync(CheckDataMaskingInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDataMaskingInstance",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDataMaskingInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the prerequisites for column encryption on an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Checks the permissions, engine, and runtime conditions of an instance before creating column encryption rules. Check both ErrorCode and ErrorMessage in the response. Only ErrorCode=Success indicates that the check passed. A successful request alone does not mean the instance meets all encryption conditions. This check does not create column encryption rules.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your account.
        /// Use the service registration endpoint of the region where the target asset resides, and configure the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckDataMaskingInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDataMaskingInstanceResponse
        /// </returns>
        public CheckDataMaskingInstanceResponse CheckDataMaskingInstance(CheckDataMaskingInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDataMaskingInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the prerequisites for column encryption on an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Checks the permissions, engine, and runtime conditions of an instance before creating column encryption rules. Check both ErrorCode and ErrorMessage in the response. Only ErrorCode=Success indicates that the check passed. A successful request alone does not mean the instance meets all encryption conditions. This check does not create column encryption rules.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your account.
        /// Use the service registration endpoint of the region where the target asset resides, and configure the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CheckDataMaskingInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDataMaskingInstanceResponse
        /// </returns>
        public async Task<CheckDataMaskingInstanceResponse> CheckDataMaskingInstanceAsync(CheckDataMaskingInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDataMaskingInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a column encryption rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a column encryption rule for a specified database, table, and columns under the same instance. Before invoking this operation, verify the instance status, supported algorithms, key, target columns, and accounts. SubRuleList is a list of target columns grouped by table. Columns is a comma-separated string of column names. Accounts in UserList are granted fullAccess plaintext access permissions. A successful request indicates only that the request has been accepted. You must invoke <a href="https://help.aliyun.com/document_detail/2859325.html">ListDataMaskingColumns</a> and <a href="https://help.aliyun.com/document_detail/2859330.html">ListDataAssetAccounts</a> to confirm the column status, account access permissions, and expiration time.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. A successful request does not mean that the operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateDataMaskingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataMaskingRuleResponse
        /// </returns>
        public CreateDataMaskingRuleResponse CreateDataMaskingRuleWithOptions(CreateDataMaskingRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataMaskingRuleShrinkRequest request = new CreateDataMaskingRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubRuleList))
            {
                request.SubRuleListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubRuleList, "SubRuleList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserList))
            {
                request.UserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserList, "UserList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncAlgorithm))
            {
                query["EncAlgorithm"] = request.EncAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyId))
            {
                query["EncryptionKeyId"] = request.EncryptionKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyMode))
            {
                query["EncryptionKeyMode"] = request.EncryptionKeyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeOperation))
            {
                query["ExpireTimeOperation"] = request.ExpireTimeOperation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskHandleId))
            {
                query["RiskHandleId"] = request.RiskHandleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubRuleListShrink))
            {
                query["SubRuleList"] = request.SubRuleListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserListShrink))
            {
                query["UserList"] = request.UserListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataMaskingRule",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataMaskingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a column encryption rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a column encryption rule for a specified database, table, and columns under the same instance. Before invoking this operation, verify the instance status, supported algorithms, key, target columns, and accounts. SubRuleList is a list of target columns grouped by table. Columns is a comma-separated string of column names. Accounts in UserList are granted fullAccess plaintext access permissions. A successful request indicates only that the request has been accepted. You must invoke <a href="https://help.aliyun.com/document_detail/2859325.html">ListDataMaskingColumns</a> and <a href="https://help.aliyun.com/document_detail/2859330.html">ListDataAssetAccounts</a> to confirm the column status, account access permissions, and expiration time.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. A successful request does not mean that the operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateDataMaskingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataMaskingRuleResponse
        /// </returns>
        public async Task<CreateDataMaskingRuleResponse> CreateDataMaskingRuleWithOptionsAsync(CreateDataMaskingRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateDataMaskingRuleShrinkRequest request = new CreateDataMaskingRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubRuleList))
            {
                request.SubRuleListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubRuleList, "SubRuleList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserList))
            {
                request.UserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserList, "UserList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncAlgorithm))
            {
                query["EncAlgorithm"] = request.EncAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyId))
            {
                query["EncryptionKeyId"] = request.EncryptionKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyMode))
            {
                query["EncryptionKeyMode"] = request.EncryptionKeyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeOperation))
            {
                query["ExpireTimeOperation"] = request.ExpireTimeOperation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskHandleId))
            {
                query["RiskHandleId"] = request.RiskHandleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubRuleListShrink))
            {
                query["SubRuleList"] = request.SubRuleListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserListShrink))
            {
                query["UserList"] = request.UserListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDataMaskingRule",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataMaskingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a column encryption rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a column encryption rule for a specified database, table, and columns under the same instance. Before invoking this operation, verify the instance status, supported algorithms, key, target columns, and accounts. SubRuleList is a list of target columns grouped by table. Columns is a comma-separated string of column names. Accounts in UserList are granted fullAccess plaintext access permissions. A successful request indicates only that the request has been accepted. You must invoke <a href="https://help.aliyun.com/document_detail/2859325.html">ListDataMaskingColumns</a> and <a href="https://help.aliyun.com/document_detail/2859330.html">ListDataAssetAccounts</a> to confirm the column status, account access permissions, and expiration time.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. A successful request does not mean that the operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataMaskingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataMaskingRuleResponse
        /// </returns>
        public CreateDataMaskingRuleResponse CreateDataMaskingRule(CreateDataMaskingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataMaskingRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a column encryption rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a column encryption rule for a specified database, table, and columns under the same instance. Before invoking this operation, verify the instance status, supported algorithms, key, target columns, and accounts. SubRuleList is a list of target columns grouped by table. Columns is a comma-separated string of column names. Accounts in UserList are granted fullAccess plaintext access permissions. A successful request indicates only that the request has been accepted. You must invoke <a href="https://help.aliyun.com/document_detail/2859325.html">ListDataMaskingColumns</a> and <a href="https://help.aliyun.com/document_detail/2859330.html">ListDataAssetAccounts</a> to confirm the column status, account access permissions, and expiration time.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. A successful request does not mean that the operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataMaskingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataMaskingRuleResponse
        /// </returns>
        public async Task<CreateDataMaskingRuleResponse> CreateDataMaskingRuleAsync(CreateDataMaskingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataMaskingRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables encryption for specified columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Disables column encryption rules for specified columns within the same instance. SubRuleList precisely specifies the database, table, and columns. If no matching rule is found, no new operation object is created. The disable request is processed asynchronously. Use ListDataMaskingColumns to verify that the column has recovered to NotEncrypted or that the target rule has been removed. DeleteFailed indicates that the shutdown failed.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained by querying your current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not indicate that the business operation is complete. Poll the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteDataMaskingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataMaskingRuleResponse
        /// </returns>
        public DeleteDataMaskingRuleResponse DeleteDataMaskingRuleWithOptions(DeleteDataMaskingRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDataMaskingRuleShrinkRequest request = new DeleteDataMaskingRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubRuleList))
            {
                request.SubRuleListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubRuleList, "SubRuleList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubRuleListShrink))
            {
                query["SubRuleList"] = request.SubRuleListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataMaskingRule",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataMaskingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables encryption for specified columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Disables column encryption rules for specified columns within the same instance. SubRuleList precisely specifies the database, table, and columns. If no matching rule is found, no new operation object is created. The disable request is processed asynchronously. Use ListDataMaskingColumns to verify that the column has recovered to NotEncrypted or that the target rule has been removed. DeleteFailed indicates that the shutdown failed.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained by querying your current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not indicate that the business operation is complete. Poll the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteDataMaskingRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataMaskingRuleResponse
        /// </returns>
        public async Task<DeleteDataMaskingRuleResponse> DeleteDataMaskingRuleWithOptionsAsync(DeleteDataMaskingRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteDataMaskingRuleShrinkRequest request = new DeleteDataMaskingRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubRuleList))
            {
                request.SubRuleListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubRuleList, "SubRuleList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubRuleListShrink))
            {
                query["SubRuleList"] = request.SubRuleListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataMaskingRule",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataMaskingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables encryption for specified columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Disables column encryption rules for specified columns within the same instance. SubRuleList precisely specifies the database, table, and columns. If no matching rule is found, no new operation object is created. The disable request is processed asynchronously. Use ListDataMaskingColumns to verify that the column has recovered to NotEncrypted or that the target rule has been removed. DeleteFailed indicates that the shutdown failed.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained by querying your current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not indicate that the business operation is complete. Poll the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataMaskingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataMaskingRuleResponse
        /// </returns>
        public DeleteDataMaskingRuleResponse DeleteDataMaskingRule(DeleteDataMaskingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataMaskingRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables encryption for specified columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Disables column encryption rules for specified columns within the same instance. SubRuleList precisely specifies the database, table, and columns. If no matching rule is found, no new operation object is created. The disable request is processed asynchronously. Use ListDataMaskingColumns to verify that the column has recovered to NotEncrypted or that the target rule has been removed. DeleteFailed indicates that the shutdown failed.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained by querying your current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not indicate that the business operation is complete. Poll the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteDataMaskingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataMaskingRuleResponse
        /// </returns>
        public async Task<DeleteDataMaskingRuleResponse> DeleteDataMaskingRuleAsync(DeleteDataMaskingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataMaskingRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permission statistics of column encryption accounts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the permission statistics of database accounts in the current region by product scope. Plaintext accounts correspond to FullAccessCount. Restricted access and decryption-prohibited accounts are counted in RestrictedAccessCount and NoneAccessCount, respectively. The number of accounts without configured permissions can be obtained by subtracting the preceding three account types from TotalCount. This operation does not accept filter conditions such as instance, database, table, or column.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained by querying the current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataMaskingAccountCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataMaskingAccountCountResponse
        /// </returns>
        public GetDataMaskingAccountCountResponse GetDataMaskingAccountCountWithOptions(GetDataMaskingAccountCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataMaskingAccountCount",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataMaskingAccountCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permission statistics of column encryption accounts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the permission statistics of database accounts in the current region by product scope. Plaintext accounts correspond to FullAccessCount. Restricted access and decryption-prohibited accounts are counted in RestrictedAccessCount and NoneAccessCount, respectively. The number of accounts without configured permissions can be obtained by subtracting the preceding three account types from TotalCount. This operation does not accept filter conditions such as instance, database, table, or column.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained by querying the current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataMaskingAccountCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataMaskingAccountCountResponse
        /// </returns>
        public async Task<GetDataMaskingAccountCountResponse> GetDataMaskingAccountCountWithOptionsAsync(GetDataMaskingAccountCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataMaskingAccountCount",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataMaskingAccountCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permission statistics of column encryption accounts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the permission statistics of database accounts in the current region by product scope. Plaintext accounts correspond to FullAccessCount. Restricted access and decryption-prohibited accounts are counted in RestrictedAccessCount and NoneAccessCount, respectively. The number of accounts without configured permissions can be obtained by subtracting the preceding three account types from TotalCount. This operation does not accept filter conditions such as instance, database, table, or column.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained by querying the current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataMaskingAccountCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataMaskingAccountCountResponse
        /// </returns>
        public GetDataMaskingAccountCountResponse GetDataMaskingAccountCount(GetDataMaskingAccountCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataMaskingAccountCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permission statistics of column encryption accounts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the permission statistics of database accounts in the current region by product scope. Plaintext accounts correspond to FullAccessCount. Restricted access and decryption-prohibited accounts are counted in RestrictedAccessCount and NoneAccessCount, respectively. The number of accounts without configured permissions can be obtained by subtracting the preceding three account types from TotalCount. This operation does not accept filter conditions such as instance, database, table, or column.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained by querying the current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId to the corresponding value, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataMaskingAccountCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataMaskingAccountCountResponse
        /// </returns>
        public async Task<GetDataMaskingAccountCountResponse> GetDataMaskingAccountCountAsync(GetDataMaskingAccountCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataMaskingAccountCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries column encryption statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the total number of columns, the number of sensitive columns, the number of encrypted columns, and the number of columns that failed to be encrypted by region, product, and categorization template. This operation returns statistics card data and does not follow the instance, database name, table name, column name, or model filters in the column list.
        /// For compatible with historical detection results, if no initial results are found for the specified template and no filtering by sensitivity level or detection model is applied, the results may backoff to built-in general detection results. To enforce strict template ownership, verify the results by using the sensitivity level or model conditions within the template.
        /// The parameter examples are provided only to illustrate the format. Replace the values with the regions, resource identifiers, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataMaskingColumnCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataMaskingColumnCountResponse
        /// </returns>
        public GetDataMaskingColumnCountResponse GetDataMaskingColumnCountWithOptions(GetDataMaskingColumnCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataMaskingColumnCount",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataMaskingColumnCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries column encryption statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the total number of columns, the number of sensitive columns, the number of encrypted columns, and the number of columns that failed to be encrypted by region, product, and categorization template. This operation returns statistics card data and does not follow the instance, database name, table name, column name, or model filters in the column list.
        /// For compatible with historical detection results, if no initial results are found for the specified template and no filtering by sensitivity level or detection model is applied, the results may backoff to built-in general detection results. To enforce strict template ownership, verify the results by using the sensitivity level or model conditions within the template.
        /// The parameter examples are provided only to illustrate the format. Replace the values with the regions, resource identifiers, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataMaskingColumnCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDataMaskingColumnCountResponse
        /// </returns>
        public async Task<GetDataMaskingColumnCountResponse> GetDataMaskingColumnCountWithOptionsAsync(GetDataMaskingColumnCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataMaskingColumnCount",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataMaskingColumnCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries column encryption statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the total number of columns, the number of sensitive columns, the number of encrypted columns, and the number of columns that failed to be encrypted by region, product, and categorization template. This operation returns statistics card data and does not follow the instance, database name, table name, column name, or model filters in the column list.
        /// For compatible with historical detection results, if no initial results are found for the specified template and no filtering by sensitivity level or detection model is applied, the results may backoff to built-in general detection results. To enforce strict template ownership, verify the results by using the sensitivity level or model conditions within the template.
        /// The parameter examples are provided only to illustrate the format. Replace the values with the regions, resource identifiers, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataMaskingColumnCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataMaskingColumnCountResponse
        /// </returns>
        public GetDataMaskingColumnCountResponse GetDataMaskingColumnCount(GetDataMaskingColumnCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataMaskingColumnCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries column encryption statistics.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the total number of columns, the number of sensitive columns, the number of encrypted columns, and the number of columns that failed to be encrypted by region, product, and categorization template. This operation returns statistics card data and does not follow the instance, database name, table name, column name, or model filters in the column list.
        /// For compatible with historical detection results, if no initial results are found for the specified template and no filtering by sensitivity level or detection model is applied, the results may backoff to built-in general detection results. To enforce strict template ownership, verify the results by using the sensitivity level or model conditions within the template.
        /// The parameter examples are provided only to illustrate the format. Replace the values with the regions, resource identifiers, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetDataMaskingColumnCountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDataMaskingColumnCountResponse
        /// </returns>
        public async Task<GetDataMaskingColumnCountResponse> GetDataMaskingColumnCountAsync(GetDataMaskingColumnCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataMaskingColumnCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the engine and kernel properties of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the DPI engine, current kernel version, O&amp;M window, and KMS encryption support of an instance. After a kernel upgrade, you can read back CurrentKernelVersion to verify the target version. If ErrorCode or ErrorMessage is present, handle the property query exception first.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides, and configure the common parameter RegionId in Settings, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceAttributeResponse
        /// </returns>
        public GetInstanceAttributeResponse GetInstanceAttributeWithOptions(GetInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceAttribute",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the engine and kernel properties of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the DPI engine, current kernel version, O&amp;M window, and KMS encryption support of an instance. After a kernel upgrade, you can read back CurrentKernelVersion to verify the target version. If ErrorCode or ErrorMessage is present, handle the property query exception first.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides, and configure the common parameter RegionId in Settings, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceAttributeResponse
        /// </returns>
        public async Task<GetInstanceAttributeResponse> GetInstanceAttributeWithOptionsAsync(GetInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceAttribute",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the engine and kernel properties of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the DPI engine, current kernel version, O&amp;M window, and KMS encryption support of an instance. After a kernel upgrade, you can read back CurrentKernelVersion to verify the target version. If ErrorCode or ErrorMessage is present, handle the property query exception first.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides, and configure the common parameter RegionId in Settings, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceAttributeResponse
        /// </returns>
        public GetInstanceAttributeResponse GetInstanceAttribute(GetInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the engine and kernel properties of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the DPI engine, current kernel version, O&amp;M window, and KMS encryption support of an instance. After a kernel upgrade, you can read back CurrentKernelVersion to verify the target version. If ErrorCode or ErrorMessage is present, handle the property query exception first.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides, and configure the common parameter RegionId in Settings, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceAttributeResponse
        /// </returns>
        public async Task<GetInstanceAttributeResponse> GetInstanceAttributeAsync(GetInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries columns and detection results of a data table.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries columns and detection results of a data table with paging. When both DataAssetSourceId and InstanceName are specified, DataAssetSourceId takes precedence. For PostgreSQL and Oracle scenarios, you can use the schema.table format for TableName and pass in the corresponding EngineType. To query the execute status of column encryption, invoke ListDataMaskingColumns.
        /// For compatible with historical detection results, if the specified template has no initial results and no filtering by sensitivity level or detection model is applied, the results may fall back to built-in general detection results. To strictly verify template ownership, use the sensitivity level or model conditions within the template for verification.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListColumnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListColumnsResponse
        /// </returns>
        public ListColumnsResponse ListColumnsWithOptions(ListColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAssetSourceId))
            {
                query["DataAssetSourceId"] = request.DataAssetSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                query["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListColumns",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListColumnsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries columns and detection results of a data table.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries columns and detection results of a data table with paging. When both DataAssetSourceId and InstanceName are specified, DataAssetSourceId takes precedence. For PostgreSQL and Oracle scenarios, you can use the schema.table format for TableName and pass in the corresponding EngineType. To query the execute status of column encryption, invoke ListDataMaskingColumns.
        /// For compatible with historical detection results, if the specified template has no initial results and no filtering by sensitivity level or detection model is applied, the results may fall back to built-in general detection results. To strictly verify template ownership, use the sensitivity level or model conditions within the template for verification.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListColumnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListColumnsResponse
        /// </returns>
        public async Task<ListColumnsResponse> ListColumnsWithOptionsAsync(ListColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAssetSourceId))
            {
                query["DataAssetSourceId"] = request.DataAssetSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                query["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListColumns",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListColumnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries columns and detection results of a data table.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries columns and detection results of a data table with paging. When both DataAssetSourceId and InstanceName are specified, DataAssetSourceId takes precedence. For PostgreSQL and Oracle scenarios, you can use the schema.table format for TableName and pass in the corresponding EngineType. To query the execute status of column encryption, invoke ListDataMaskingColumns.
        /// For compatible with historical detection results, if the specified template has no initial results and no filtering by sensitivity level or detection model is applied, the results may fall back to built-in general detection results. To strictly verify template ownership, use the sensitivity level or model conditions within the template for verification.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListColumnsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListColumnsResponse
        /// </returns>
        public ListColumnsResponse ListColumns(ListColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListColumnsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries columns and detection results of a data table.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries columns and detection results of a data table with paging. When both DataAssetSourceId and InstanceName are specified, DataAssetSourceId takes precedence. For PostgreSQL and Oracle scenarios, you can use the schema.table format for TableName and pass in the corresponding EngineType. To query the execute status of column encryption, invoke ListDataMaskingColumns.
        /// For compatible with historical detection results, if the specified template has no initial results and no filtering by sensitivity level or detection model is applied, the results may fall back to built-in general detection results. To strictly verify template ownership, use the sensitivity level or model conditions within the template for verification.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListColumnsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListColumnsResponse
        /// </returns>
        public async Task<ListColumnsResponse> ListColumnsAsync(ListColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListColumnsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries database accounts and column encryption permissions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries database accounts and their column encryption access permissions with paging. Use this operation to select plaintext accounts when creating rules, and to verify AuthRole, EncryptionKeyMode, and ExpireTime before and after modifying account permissions. AccountName filters by exact account name. The account identity is obtained from Items[].Id.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your current account query.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataAssetAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataAssetAccountsResponse
        /// </returns>
        public ListDataAssetAccountsResponse ListDataAssetAccountsWithOptions(ListDataAssetAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthRole))
            {
                query["AuthRole"] = request.AuthRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataAssetAccounts",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataAssetAccountsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries database accounts and column encryption permissions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries database accounts and their column encryption access permissions with paging. Use this operation to select plaintext accounts when creating rules, and to verify AuthRole, EncryptionKeyMode, and ExpireTime before and after modifying account permissions. AccountName filters by exact account name. The account identity is obtained from Items[].Id.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your current account query.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataAssetAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataAssetAccountsResponse
        /// </returns>
        public async Task<ListDataAssetAccountsResponse> ListDataAssetAccountsWithOptionsAsync(ListDataAssetAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountName))
            {
                query["AccountName"] = request.AccountName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthRole))
            {
                query["AuthRole"] = request.AuthRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataAssetAccounts",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataAssetAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries database accounts and column encryption permissions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries database accounts and their column encryption access permissions with paging. Use this operation to select plaintext accounts when creating rules, and to verify AuthRole, EncryptionKeyMode, and ExpireTime before and after modifying account permissions. AccountName filters by exact account name. The account identity is obtained from Items[].Id.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your current account query.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataAssetAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataAssetAccountsResponse
        /// </returns>
        public ListDataAssetAccountsResponse ListDataAssetAccounts(ListDataAssetAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataAssetAccountsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries database accounts and column encryption permissions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries database accounts and their column encryption access permissions with paging. Use this operation to select plaintext accounts when creating rules, and to verify AuthRole, EncryptionKeyMode, and ExpireTime before and after modifying account permissions. AccountName filters by exact account name. The account identity is obtained from Items[].Id.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your current account query.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataAssetAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataAssetAccountsResponse
        /// </returns>
        public async Task<ListDataAssetAccountsResponse> ListDataAssetAccountsAsync(ListDataAssetAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataAssetAccountsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the encryption status and detection results of columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on columns and their encryption status, sensitivity levels, and detection models. You can filter results by combining template, product, instance, database, table, column name, model, and sensitivity level. Use this operation to read back results after creating or shutting down a rule. Processing and Deleting are intermediate states. Failed and DeleteFailed indicate operation failures. The casing of the parameter name RiskLeveLId must be preserved as-is.
        /// When querying by product, use a single ProductId or the corresponding ProductCode. Column queries do not support multi-product filtering through ProductIds. Query each product separately for multi-product scenarios.
        /// For compatibility with historical detection results, if no first-page results are found for the specified template and no sensitivity level or detection model filter is applied, the results may fall back to built-in general detection results. To enforce strict template ownership, also use a level or model condition from that template for verification.
        /// Parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, for example, cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingColumnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingColumnsResponse
        /// </returns>
        public ListDataMaskingColumnsResponse ListDataMaskingColumnsWithOptions(ListDataMaskingColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnName))
            {
                query["ColumnName"] = request.ColumnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaskingStatus))
            {
                query["MaskingStatus"] = request.MaskingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLeveLId))
            {
                query["RiskLeveLId"] = request.RiskLeveLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelIds))
            {
                query["RiskLevelIds"] = request.RiskLevelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRuleIds))
            {
                query["TemplateRuleIds"] = request.TemplateRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataMaskingColumns",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataMaskingColumnsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the encryption status and detection results of columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on columns and their encryption status, sensitivity levels, and detection models. You can filter results by combining template, product, instance, database, table, column name, model, and sensitivity level. Use this operation to read back results after creating or shutting down a rule. Processing and Deleting are intermediate states. Failed and DeleteFailed indicate operation failures. The casing of the parameter name RiskLeveLId must be preserved as-is.
        /// When querying by product, use a single ProductId or the corresponding ProductCode. Column queries do not support multi-product filtering through ProductIds. Query each product separately for multi-product scenarios.
        /// For compatibility with historical detection results, if no first-page results are found for the specified template and no sensitivity level or detection model filter is applied, the results may fall back to built-in general detection results. To enforce strict template ownership, also use a level or model condition from that template for verification.
        /// Parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, for example, cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingColumnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingColumnsResponse
        /// </returns>
        public async Task<ListDataMaskingColumnsResponse> ListDataMaskingColumnsWithOptionsAsync(ListDataMaskingColumnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnName))
            {
                query["ColumnName"] = request.ColumnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaskingStatus))
            {
                query["MaskingStatus"] = request.MaskingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLeveLId))
            {
                query["RiskLeveLId"] = request.RiskLeveLId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelIds))
            {
                query["RiskLevelIds"] = request.RiskLevelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRuleIds))
            {
                query["TemplateRuleIds"] = request.TemplateRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataMaskingColumns",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataMaskingColumnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the encryption status and detection results of columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on columns and their encryption status, sensitivity levels, and detection models. You can filter results by combining template, product, instance, database, table, column name, model, and sensitivity level. Use this operation to read back results after creating or shutting down a rule. Processing and Deleting are intermediate states. Failed and DeleteFailed indicate operation failures. The casing of the parameter name RiskLeveLId must be preserved as-is.
        /// When querying by product, use a single ProductId or the corresponding ProductCode. Column queries do not support multi-product filtering through ProductIds. Query each product separately for multi-product scenarios.
        /// For compatibility with historical detection results, if no first-page results are found for the specified template and no sensitivity level or detection model filter is applied, the results may fall back to built-in general detection results. To enforce strict template ownership, also use a level or model condition from that template for verification.
        /// Parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, for example, cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingColumnsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingColumnsResponse
        /// </returns>
        public ListDataMaskingColumnsResponse ListDataMaskingColumns(ListDataMaskingColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataMaskingColumnsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the encryption status and detection results of columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on columns and their encryption status, sensitivity levels, and detection models. You can filter results by combining template, product, instance, database, table, column name, model, and sensitivity level. Use this operation to read back results after creating or shutting down a rule. Processing and Deleting are intermediate states. Failed and DeleteFailed indicate operation failures. The casing of the parameter name RiskLeveLId must be preserved as-is.
        /// When querying by product, use a single ProductId or the corresponding ProductCode. Column queries do not support multi-product filtering through ProductIds. Query each product separately for multi-product scenarios.
        /// For compatibility with historical detection results, if no first-page results are found for the specified template and no sensitivity level or detection model filter is applied, the results may fall back to built-in general detection results. To enforce strict template ownership, also use a level or model condition from that template for verification.
        /// Parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, for example, cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingColumnsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingColumnsResponse
        /// </returns>
        public async Task<ListDataMaskingColumnsResponse> ListDataMaskingColumnsAsync(ListDataMaskingColumnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataMaskingColumnsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the column encryption algorithms supported by an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available column encryption algorithms for a specified instance and the restriction reasons for each algorithm. Before selecting an algorithm, check the ErrorCode and ErrorMessage of the corresponding entry. Do not assume that all instances support the same set of algorithms.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingEncryptionAlgorithmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingEncryptionAlgorithmsResponse
        /// </returns>
        public ListDataMaskingEncryptionAlgorithmsResponse ListDataMaskingEncryptionAlgorithmsWithOptions(ListDataMaskingEncryptionAlgorithmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataMaskingEncryptionAlgorithms",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataMaskingEncryptionAlgorithmsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the column encryption algorithms supported by an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available column encryption algorithms for a specified instance and the restriction reasons for each algorithm. Before selecting an algorithm, check the ErrorCode and ErrorMessage of the corresponding entry. Do not assume that all instances support the same set of algorithms.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingEncryptionAlgorithmsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingEncryptionAlgorithmsResponse
        /// </returns>
        public async Task<ListDataMaskingEncryptionAlgorithmsResponse> ListDataMaskingEncryptionAlgorithmsWithOptionsAsync(ListDataMaskingEncryptionAlgorithmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataMaskingEncryptionAlgorithms",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataMaskingEncryptionAlgorithmsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the column encryption algorithms supported by an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available column encryption algorithms for a specified instance and the restriction reasons for each algorithm. Before selecting an algorithm, check the ErrorCode and ErrorMessage of the corresponding entry. Do not assume that all instances support the same set of algorithms.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingEncryptionAlgorithmsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingEncryptionAlgorithmsResponse
        /// </returns>
        public ListDataMaskingEncryptionAlgorithmsResponse ListDataMaskingEncryptionAlgorithms(ListDataMaskingEncryptionAlgorithmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataMaskingEncryptionAlgorithmsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the column encryption algorithms supported by an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available column encryption algorithms for a specified instance and the restriction reasons for each algorithm. Before selecting an algorithm, check the ErrorCode and ErrorMessage of the corresponding entry. Do not assume that all instances support the same set of algorithms.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingEncryptionAlgorithmsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingEncryptionAlgorithmsResponse
        /// </returns>
        public async Task<ListDataMaskingEncryptionAlgorithmsResponse> ListDataMaskingEncryptionAlgorithmsAsync(ListDataMaskingEncryptionAlgorithmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataMaskingEncryptionAlgorithmsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries column encryption instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries column encryption instances by paging and supports filtering by product, detection template, and database/table/column. Instance-level status filtering differs from column-level status filtering in scope. To find all unencrypted sensitive columns, first enumerate the instances of the target product, and then use ListDataMaskingColumns to filter by NotEncrypted. This prevents you from missing instances that are partially encrypted.
        /// To filter precisely by EngineType, read all candidate pages and then filter by the returned values. Some query paths do not apply this parameter. The matching semantics of InstanceId vary depending on the query combination. To precisely locate an instance, verify the complete instance identity in the response.
        /// The parameter examples are provided only to illustrate the format. Replace the values with the region IDs, resource identities, and configuration values that you obtain from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingInstancesResponse
        /// </returns>
        public ListDataMaskingInstancesResponse ListDataMaskingInstancesWithOptions(ListDataMaskingInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnName))
            {
                query["ColumnName"] = request.ColumnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaskingStatus))
            {
                query["MaskingStatus"] = request.MaskingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTagId))
            {
                query["ModelTagId"] = request.ModelTagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelIds))
            {
                query["RiskLevelIds"] = request.RiskLevelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRuleIds))
            {
                query["TemplateRuleIds"] = request.TemplateRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataMaskingInstances",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataMaskingInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries column encryption instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries column encryption instances by paging and supports filtering by product, detection template, and database/table/column. Instance-level status filtering differs from column-level status filtering in scope. To find all unencrypted sensitive columns, first enumerate the instances of the target product, and then use ListDataMaskingColumns to filter by NotEncrypted. This prevents you from missing instances that are partially encrypted.
        /// To filter precisely by EngineType, read all candidate pages and then filter by the returned values. Some query paths do not apply this parameter. The matching semantics of InstanceId vary depending on the query combination. To precisely locate an instance, verify the complete instance identity in the response.
        /// The parameter examples are provided only to illustrate the format. Replace the values with the region IDs, resource identities, and configuration values that you obtain from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingInstancesResponse
        /// </returns>
        public async Task<ListDataMaskingInstancesResponse> ListDataMaskingInstancesWithOptionsAsync(ListDataMaskingInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnName))
            {
                query["ColumnName"] = request.ColumnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaskingStatus))
            {
                query["MaskingStatus"] = request.MaskingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelTagId))
            {
                query["ModelTagId"] = request.ModelTagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductIds))
            {
                query["ProductIds"] = request.ProductIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelIds))
            {
                query["RiskLevelIds"] = request.RiskLevelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateRuleIds))
            {
                query["TemplateRuleIds"] = request.TemplateRuleIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataMaskingInstances",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataMaskingInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries column encryption instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries column encryption instances by paging and supports filtering by product, detection template, and database/table/column. Instance-level status filtering differs from column-level status filtering in scope. To find all unencrypted sensitive columns, first enumerate the instances of the target product, and then use ListDataMaskingColumns to filter by NotEncrypted. This prevents you from missing instances that are partially encrypted.
        /// To filter precisely by EngineType, read all candidate pages and then filter by the returned values. Some query paths do not apply this parameter. The matching semantics of InstanceId vary depending on the query combination. To precisely locate an instance, verify the complete instance identity in the response.
        /// The parameter examples are provided only to illustrate the format. Replace the values with the region IDs, resource identities, and configuration values that you obtain from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingInstancesResponse
        /// </returns>
        public ListDataMaskingInstancesResponse ListDataMaskingInstances(ListDataMaskingInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataMaskingInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries column encryption instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries column encryption instances by paging and supports filtering by product, detection template, and database/table/column. Instance-level status filtering differs from column-level status filtering in scope. To find all unencrypted sensitive columns, first enumerate the instances of the target product, and then use ListDataMaskingColumns to filter by NotEncrypted. This prevents you from missing instances that are partially encrypted.
        /// To filter precisely by EngineType, read all candidate pages and then filter by the returned values. Some query paths do not apply this parameter. The matching semantics of InstanceId vary depending on the query combination. To precisely locate an instance, verify the complete instance identity in the response.
        /// The parameter examples are provided only to illustrate the format. Replace the values with the region IDs, resource identities, and configuration values that you obtain from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataMaskingInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataMaskingInstancesResponse
        /// </returns>
        public async Task<ListDataMaskingInstancesResponse> ListDataMaskingInstancesAsync(ListDataMaskingInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataMaskingInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the databases of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query on managed data sources by using paging. In relational database scenarios, locate the instance by using ProductCode and InstanceId, and select a database from Items[].DbName. This operation queries the database inventory and does not filter by data categorization and classification templates.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke this operation.
        /// Use the service registration endpoint of the region where the target asset resides and configure the settings of the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public ListDataSourcesResponse ListDataSourcesWithOptions(ListDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectStatus))
            {
                query["ConnectStatus"] = request.ConnectStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAssetId))
            {
                query["DataAssetId"] = request.DataAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyStatus))
            {
                query["IdentifyStatus"] = request.IdentifyStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSources",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the databases of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query on managed data sources by using paging. In relational database scenarios, locate the instance by using ProductCode and InstanceId, and select a database from Items[].DbName. This operation queries the database inventory and does not filter by data categorization and classification templates.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke this operation.
        /// Use the service registration endpoint of the region where the target asset resides and configure the settings of the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public async Task<ListDataSourcesResponse> ListDataSourcesWithOptionsAsync(ListDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectStatus))
            {
                query["ConnectStatus"] = request.ConnectStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAssetId))
            {
                query["DataAssetId"] = request.DataAssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                query["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["DbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EngineType))
            {
                query["EngineType"] = request.EngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyStatus))
            {
                query["IdentifyStatus"] = request.IdentifyStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSources",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the databases of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query on managed data sources by using paging. In relational database scenarios, locate the instance by using ProductCode and InstanceId, and select a database from Items[].DbName. This operation queries the database inventory and does not filter by data categorization and classification templates.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke this operation.
        /// Use the service registration endpoint of the region where the target asset resides and configure the settings of the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the databases of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query on managed data sources by using paging. In relational database scenarios, locate the instance by using ProductCode and InstanceId, and select a database from Items[].DbName. This operation queries the database inventory and does not filter by data categorization and classification templates.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke this operation.
        /// Use the service registration endpoint of the region where the target asset resides and configure the settings of the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSourcesResponse
        /// </returns>
        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sensitive data detection models of a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the valid sensitive data detection models within a specified template and returns RuleList. If TemplateId is not specified, the currently enabled template is used. Use RuleList[].Id to obtain model identifiers, which can be used for filtering with TemplateRuleIds.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIdentifyModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdentifyModelsResponse
        /// </returns>
        public ListIdentifyModelsResponse ListIdentifyModelsWithOptions(ListIdentifyModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterAuditModel))
            {
                query["FilterAuditModel"] = request.FilterAuditModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentifyModels",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentifyModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sensitive data detection models of a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the valid sensitive data detection models within a specified template and returns RuleList. If TemplateId is not specified, the currently enabled template is used. Use RuleList[].Id to obtain model identifiers, which can be used for filtering with TemplateRuleIds.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIdentifyModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdentifyModelsResponse
        /// </returns>
        public async Task<ListIdentifyModelsResponse> ListIdentifyModelsWithOptionsAsync(ListIdentifyModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterAuditModel))
            {
                query["FilterAuditModel"] = request.FilterAuditModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdentifyModels",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdentifyModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sensitive data detection models of a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the valid sensitive data detection models within a specified template and returns RuleList. If TemplateId is not specified, the currently enabled template is used. Use RuleList[].Id to obtain model identifiers, which can be used for filtering with TemplateRuleIds.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIdentifyModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdentifyModelsResponse
        /// </returns>
        public ListIdentifyModelsResponse ListIdentifyModels(ListIdentifyModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIdentifyModelsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sensitive data detection models of a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the valid sensitive data detection models within a specified template and returns RuleList. If TemplateId is not specified, the currently enabled template is used. Use RuleList[].Id to obtain model identifiers, which can be used for filtering with TemplateRuleIds.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListIdentifyModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdentifyModelsResponse
        /// </returns>
        public async Task<ListIdentifyModelsResponse> ListIdentifyModelsAsync(ListIdentifyModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIdentifyModelsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available KMS keys for column encryption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available KMS key identities and aliases for column encryption configuration of a specified instance. Before using a KMS key, verify the key status and usage conditions by invoking the DescribeKey operation of KMS. This operation does not return key plaintext.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identities, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKmsKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKmsKeysResponse
        /// </returns>
        public ListKmsKeysResponse ListKmsKeysWithOptions(ListKmsKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKmsKeys",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKmsKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available KMS keys for column encryption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available KMS key identities and aliases for column encryption configuration of a specified instance. Before using a KMS key, verify the key status and usage conditions by invoking the DescribeKey operation of KMS. This operation does not return key plaintext.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identities, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKmsKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKmsKeysResponse
        /// </returns>
        public async Task<ListKmsKeysResponse> ListKmsKeysWithOptionsAsync(ListKmsKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKmsKeys",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListKmsKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available KMS keys for column encryption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available KMS key identities and aliases for column encryption configuration of a specified instance. Before using a KMS key, verify the key status and usage conditions by invoking the DescribeKey operation of KMS. This operation does not return key plaintext.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identities, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKmsKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKmsKeysResponse
        /// </returns>
        public ListKmsKeysResponse ListKmsKeys(ListKmsKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKmsKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available KMS keys for column encryption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available KMS key identities and aliases for column encryption configuration of a specified instance. Before using a KMS key, verify the key status and usage conditions by invoking the DescribeKey operation of KMS. This operation does not return key plaintext.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identities, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListKmsKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKmsKeysResponse
        /// </returns>
        public async Task<ListKmsKeysResponse> ListKmsKeysAsync(ListKmsKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKmsKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available kernel versions for upgrade.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the kernel versions available for an instance. When upgrading, select the target version from KernelVersions[].KernelVersion. Do not manually construct version numbers.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMiniEngineVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMiniEngineVersionsResponse
        /// </returns>
        public ListMiniEngineVersionsResponse ListMiniEngineVersionsWithOptions(ListMiniEngineVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMiniEngineVersions",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMiniEngineVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available kernel versions for upgrade.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the kernel versions available for an instance. When upgrading, select the target version from KernelVersions[].KernelVersion. Do not manually construct version numbers.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMiniEngineVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMiniEngineVersionsResponse
        /// </returns>
        public async Task<ListMiniEngineVersionsResponse> ListMiniEngineVersionsWithOptionsAsync(ListMiniEngineVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMiniEngineVersions",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMiniEngineVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available kernel versions for upgrade.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the kernel versions available for an instance. When upgrading, select the target version from KernelVersions[].KernelVersion. Do not manually construct version numbers.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMiniEngineVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMiniEngineVersionsResponse
        /// </returns>
        public ListMiniEngineVersionsResponse ListMiniEngineVersions(ListMiniEngineVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMiniEngineVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the available kernel versions for upgrade.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the kernel versions available for an instance. When upgrading, select the target version from KernelVersions[].KernelVersion. Do not manually construct version numbers.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMiniEngineVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMiniEngineVersionsResponse
        /// </returns>
        public async Task<ListMiniEngineVersionsResponse> ListMiniEngineVersionsAsync(ListMiniEngineVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMiniEngineVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where assets reside.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of regions where the current account has assets. You can use the returned region IDs as the RegionId parameter for subsequent region-specific API operations. You can filter regions by whether audit or detection is enabled. The returned region list is not equivalent to the full list of regions supported by all Alibaba Cloud services.
        /// The parameter examples are provided only to illustrate the format. Replace them with the actual region IDs, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegionsWithOptions(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Audited))
            {
                query["Audited"] = request.Audited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identified))
            {
                query["Identified"] = request.Identified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where assets reside.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of regions where the current account has assets. You can use the returned region IDs as the RegionId parameter for subsequent region-specific API operations. You can filter regions by whether audit or detection is enabled. The returned region list is not equivalent to the full list of regions supported by all Alibaba Cloud services.
        /// The parameter examples are provided only to illustrate the format. Replace them with the actual region IDs, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Audited))
            {
                query["Audited"] = request.Audited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identified))
            {
                query["Identified"] = request.Identified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where assets reside.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of regions where the current account has assets. You can use the returned region IDs as the RegionId parameter for subsequent region-specific API operations. You can filter regions by whether audit or detection is enabled. The returned region list is not equivalent to the full list of regions supported by all Alibaba Cloud services.
        /// The parameter examples are provided only to illustrate the format. Replace them with the actual region IDs, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where assets reside.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of regions where the current account has assets. You can use the returned region IDs as the RegionId parameter for subsequent region-specific API operations. You can filter regions by whether audit or detection is enabled. The returned region list is not equivalent to the full list of regions supported by all Alibaba Cloud services.
        /// The parameter examples are provided only to illustrate the format. Replace them with the actual region IDs, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sensitivity levels of a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the sensitivity levels in a data classification template. Use the returned level ID for subsequent queries. Do not use level names such as S1 or S2 directly as the RiskLevelId.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRiskLevelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRiskLevelsResponse
        /// </returns>
        public ListRiskLevelsResponse ListRiskLevelsWithOptions(ListRiskLevelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRiskLevels",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRiskLevelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sensitivity levels of a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the sensitivity levels in a data classification template. Use the returned level ID for subsequent queries. Do not use level names such as S1 or S2 directly as the RiskLevelId.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRiskLevelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRiskLevelsResponse
        /// </returns>
        public async Task<ListRiskLevelsResponse> ListRiskLevelsWithOptionsAsync(ListRiskLevelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRiskLevels",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRiskLevelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sensitivity levels of a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the sensitivity levels in a data classification template. Use the returned level ID for subsequent queries. Do not use level names such as S1 or S2 directly as the RiskLevelId.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRiskLevelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRiskLevelsResponse
        /// </returns>
        public ListRiskLevelsResponse ListRiskLevels(ListRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRiskLevelsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the sensitivity levels of a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the sensitivity levels in a data classification template. Use the returned level ID for subsequent queries. Do not use level names such as S1 or S2 directly as the RiskLevelId.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identifiers, and configuration values obtained from your account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRiskLevelsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRiskLevelsResponse
        /// </returns>
        public async Task<ListRiskLevelsResponse> ListRiskLevelsAsync(ListRiskLevelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRiskLevelsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries database tables.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on data tables and detection results in a database. For relational database scenarios, set DataAssetSourceId to the instance identity and DataSourceName to the database name. Table names in PostgreSQL and Oracle may include a schema prefix. Pass the table name as-is in subsequent column queries.
        /// For compatibility with historical detection results, if no results are found on the first page for the specified template and no filtering by sensitivity level or detection model is applied, the results may backoff to built-in general detection results. To strictly verify template ownership, also use the sensitivity level or model conditions within the template.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTablesWithOptions(ListTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAssetSourceId))
            {
                query["DataAssetSourceId"] = request.DataAssetSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                query["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries database tables.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on data tables and detection results in a database. For relational database scenarios, set DataAssetSourceId to the instance identity and DataSourceName to the database name. Table names in PostgreSQL and Oracle may include a schema prefix. Pass the table name as-is in subsequent column queries.
        /// For compatibility with historical detection results, if no results are found on the first page for the specified template and no filtering by sensitivity level or detection model is applied, the results may backoff to built-in general detection results. To strictly verify template ownership, also use the sensitivity level or model conditions within the template.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesWithOptionsAsync(ListTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataAssetSourceId))
            {
                query["DataAssetSourceId"] = request.DataAssetSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceName))
            {
                query["DataSourceName"] = request.DataSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["Marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevelId))
            {
                query["RiskLevelId"] = request.RiskLevelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries database tables.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on data tables and detection results in a database. For relational database scenarios, set DataAssetSourceId to the instance identity and DataSourceName to the database name. Table names in PostgreSQL and Oracle may include a schema prefix. Pass the table name as-is in subsequent column queries.
        /// For compatibility with historical detection results, if no results are found on the first page for the specified template and no filtering by sensitivity level or detection model is applied, the results may backoff to built-in general detection results. To strictly verify template ownership, also use the sensitivity level or model conditions within the template.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTables(ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTablesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries database tables.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on data tables and detection results in a database. For relational database scenarios, set DataAssetSourceId to the instance identity and DataSourceName to the database name. Table names in PostgreSQL and Oracle may include a schema prefix. Pass the table name as-is in subsequent column queries.
        /// For compatibility with historical detection results, if no results are found on the first page for the specified template and no filtering by sensitivity level or detection model is applied, the results may backoff to built-in general detection results. To strictly verify template ownership, also use the sensitivity level or model conditions within the template.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your current account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTablesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries classification and grading templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the classification and grading templates available to the current account. Use Items[].Id as the TemplateId for subsequent API calls. Detection models and sensitivity levels must come from the same template.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageScenario))
            {
                query["UsageScenario"] = request.UsageScenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries classification and grading templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the classification and grading templates available to the current account. Use Items[].Id as the TemplateId for subsequent API calls. Detection models and sensitivity levels must come from the same template.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureType))
            {
                query["FeatureType"] = request.FeatureType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageScenario))
            {
                query["UsageScenario"] = request.UsageScenario;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTemplates",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries classification and grading templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the classification and grading templates available to the current account. Use Items[].Id as the TemplateId for subsequent API calls. Detection models and sensitivity levels must come from the same template.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries classification and grading templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the classification and grading templates available to the current account. Use Items[].Id as the TemplateId for subsequent API calls. Detection models and sensitivity levels must come from the same template.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identifiers, and configuration values obtained from your current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTemplatesResponse
        /// </returns>
        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the summary of sensitive data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the statistics of sensitive data from the overview, data catalog, or aggregated by region. CountType=41 returns overview statistics, 42 returns data catalog statistics for a specified product, and 43 returns data aggregated by region and template. The column encryption console uses CountType=43 with ProductCodeList to obtain region and template candidates. The statistics may come from pre-generated summary results and do not indicate that a recently initiated synchronization or encryption operation has completed.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identifiers, and configuration values obtained by querying your current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTotalSensitiveInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTotalSensitiveInfoResponse
        /// </returns>
        public ListTotalSensitiveInfoResponse ListTotalSensitiveInfoWithOptions(ListTotalSensitiveInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountType))
            {
                query["CountType"] = request.CountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCodeList))
            {
                query["ProductCodeList"] = request.ProductCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTotalSensitiveInfo",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTotalSensitiveInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the summary of sensitive data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the statistics of sensitive data from the overview, data catalog, or aggregated by region. CountType=41 returns overview statistics, 42 returns data catalog statistics for a specified product, and 43 returns data aggregated by region and template. The column encryption console uses CountType=43 with ProductCodeList to obtain region and template candidates. The statistics may come from pre-generated summary results and do not indicate that a recently initiated synchronization or encryption operation has completed.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identifiers, and configuration values obtained by querying your current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTotalSensitiveInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTotalSensitiveInfoResponse
        /// </returns>
        public async Task<ListTotalSensitiveInfoResponse> ListTotalSensitiveInfoWithOptionsAsync(ListTotalSensitiveInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountType))
            {
                query["CountType"] = request.CountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCodeList))
            {
                query["ProductCodeList"] = request.ProductCodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTotalSensitiveInfo",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTotalSensitiveInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the summary of sensitive data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the statistics of sensitive data from the overview, data catalog, or aggregated by region. CountType=41 returns overview statistics, 42 returns data catalog statistics for a specified product, and 43 returns data aggregated by region and template. The column encryption console uses CountType=43 with ProductCodeList to obtain region and template candidates. The statistics may come from pre-generated summary results and do not indicate that a recently initiated synchronization or encryption operation has completed.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identifiers, and configuration values obtained by querying your current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTotalSensitiveInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTotalSensitiveInfoResponse
        /// </returns>
        public ListTotalSensitiveInfoResponse ListTotalSensitiveInfo(ListTotalSensitiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTotalSensitiveInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the summary of sensitive data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the statistics of sensitive data from the overview, data catalog, or aggregated by region. CountType=41 returns overview statistics, 42 returns data catalog statistics for a specified product, and 43 returns data aggregated by region and template. The column encryption console uses CountType=43 with ProductCodeList to obtain region and template candidates. The statistics may come from pre-generated summary results and do not indicate that a recently initiated synchronization or encryption operation has completed.
        /// The parameter examples are provided only to illustrate the format. Replace them with the regions, resource identifiers, and configuration values obtained by querying your current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTotalSensitiveInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTotalSensitiveInfoResponse
        /// </returns>
        public async Task<ListTotalSensitiveInfoResponse> ListTotalSensitiveInfoAsync(ListTotalSensitiveInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTotalSensitiveInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronizes the assets of a specified product in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Triggers asset synchronization for a specified product in the current region. The scope applies to the product and region, and is not limited to a specific instance. A successful request only indicates that the request is accepted. You can then verify asset changes by checking the lists of instances, databases, tables, and columns. This operation does not return a public node identifier for polling.
        /// Parameter examples are for format illustration only. When you invoke this operation, replace them with the region, resource identifiers, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target assets reside, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target assets.
        /// This operation returns only RequestId. Request acceptance does not mean that the business operation is complete. You should check the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyncDataAssetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncDataAssetsResponse
        /// </returns>
        public SyncDataAssetsResponse SyncDataAssetsWithOptions(SyncDataAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncDataAssets",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDataAssetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronizes the assets of a specified product in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Triggers asset synchronization for a specified product in the current region. The scope applies to the product and region, and is not limited to a specific instance. A successful request only indicates that the request is accepted. You can then verify asset changes by checking the lists of instances, databases, tables, and columns. This operation does not return a public node identifier for polling.
        /// Parameter examples are for format illustration only. When you invoke this operation, replace them with the region, resource identifiers, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target assets reside, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target assets.
        /// This operation returns only RequestId. Request acceptance does not mean that the business operation is complete. You should check the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyncDataAssetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncDataAssetsResponse
        /// </returns>
        public async Task<SyncDataAssetsResponse> SyncDataAssetsWithOptionsAsync(SyncDataAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncDataAssets",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDataAssetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronizes the assets of a specified product in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Triggers asset synchronization for a specified product in the current region. The scope applies to the product and region, and is not limited to a specific instance. A successful request only indicates that the request is accepted. You can then verify asset changes by checking the lists of instances, databases, tables, and columns. This operation does not return a public node identifier for polling.
        /// Parameter examples are for format illustration only. When you invoke this operation, replace them with the region, resource identifiers, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target assets reside, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target assets.
        /// This operation returns only RequestId. Request acceptance does not mean that the business operation is complete. You should check the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyncDataAssetsRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncDataAssetsResponse
        /// </returns>
        public SyncDataAssetsResponse SyncDataAssets(SyncDataAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncDataAssetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Synchronizes the assets of a specified product in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Triggers asset synchronization for a specified product in the current region. The scope applies to the product and region, and is not limited to a specific instance. A successful request only indicates that the request is accepted. You can then verify asset changes by checking the lists of instances, databases, tables, and columns. This operation does not return a public node identifier for polling.
        /// Parameter examples are for format illustration only. When you invoke this operation, replace them with the region, resource identifiers, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target assets reside, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target assets.
        /// This operation returns only RequestId. Request acceptance does not mean that the business operation is complete. You should check the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SyncDataAssetsRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncDataAssetsResponse
        /// </returns>
        public async Task<SyncDataAssetsResponse> SyncDataAssetsAsync(SyncDataAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncDataAssetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the column encryption algorithm and key for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the instance-level column encryption algorithm and key configuration, which affects the column encryption configuration of the instance. The current implementation supports ApsaraDB RDS for MySQL and PolarDB-X 2.0. Query the algorithms and keys supported by the instance before invoking this operation. This operation does not have an EncryptionKeyMode parameter. Configure the parameter based on the usage conditions of EncryptionKeyId. After a successful request, read back the instance encryption configuration and column status. Do not determine completion based solely on the RequestId.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained by querying your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and set the common parameter RegionId, for example, cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only the RequestId. A successful request does not indicate that the business operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataMaskingEncryptionAlgorithmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataMaskingEncryptionAlgorithmResponse
        /// </returns>
        public UpdateDataMaskingEncryptionAlgorithmResponse UpdateDataMaskingEncryptionAlgorithmWithOptions(UpdateDataMaskingEncryptionAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionAlgorithm))
            {
                query["EncryptionAlgorithm"] = request.EncryptionAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyId))
            {
                query["EncryptionKeyId"] = request.EncryptionKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataMaskingEncryptionAlgorithm",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataMaskingEncryptionAlgorithmResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the column encryption algorithm and key for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the instance-level column encryption algorithm and key configuration, which affects the column encryption configuration of the instance. The current implementation supports ApsaraDB RDS for MySQL and PolarDB-X 2.0. Query the algorithms and keys supported by the instance before invoking this operation. This operation does not have an EncryptionKeyMode parameter. Configure the parameter based on the usage conditions of EncryptionKeyId. After a successful request, read back the instance encryption configuration and column status. Do not determine completion based solely on the RequestId.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained by querying your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and set the common parameter RegionId, for example, cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only the RequestId. A successful request does not indicate that the business operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataMaskingEncryptionAlgorithmRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataMaskingEncryptionAlgorithmResponse
        /// </returns>
        public async Task<UpdateDataMaskingEncryptionAlgorithmResponse> UpdateDataMaskingEncryptionAlgorithmWithOptionsAsync(UpdateDataMaskingEncryptionAlgorithmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionAlgorithm))
            {
                query["EncryptionAlgorithm"] = request.EncryptionAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyId))
            {
                query["EncryptionKeyId"] = request.EncryptionKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataMaskingEncryptionAlgorithm",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataMaskingEncryptionAlgorithmResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the column encryption algorithm and key for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the instance-level column encryption algorithm and key configuration, which affects the column encryption configuration of the instance. The current implementation supports ApsaraDB RDS for MySQL and PolarDB-X 2.0. Query the algorithms and keys supported by the instance before invoking this operation. This operation does not have an EncryptionKeyMode parameter. Configure the parameter based on the usage conditions of EncryptionKeyId. After a successful request, read back the instance encryption configuration and column status. Do not determine completion based solely on the RequestId.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained by querying your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and set the common parameter RegionId, for example, cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only the RequestId. A successful request does not indicate that the business operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataMaskingEncryptionAlgorithmRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataMaskingEncryptionAlgorithmResponse
        /// </returns>
        public UpdateDataMaskingEncryptionAlgorithmResponse UpdateDataMaskingEncryptionAlgorithm(UpdateDataMaskingEncryptionAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataMaskingEncryptionAlgorithmWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the column encryption algorithm and key for an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the instance-level column encryption algorithm and key configuration, which affects the column encryption configuration of the instance. The current implementation supports ApsaraDB RDS for MySQL and PolarDB-X 2.0. Query the algorithms and keys supported by the instance before invoking this operation. This operation does not have an EncryptionKeyMode parameter. Configure the parameter based on the usage conditions of EncryptionKeyId. After a successful request, read back the instance encryption configuration and column status. Do not determine completion based solely on the RequestId.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained by querying your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and set the common parameter RegionId, for example, cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only the RequestId. A successful request does not indicate that the business operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataMaskingEncryptionAlgorithmRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataMaskingEncryptionAlgorithmResponse
        /// </returns>
        public async Task<UpdateDataMaskingEncryptionAlgorithmResponse> UpdateDataMaskingEncryptionAlgorithmAsync(UpdateDataMaskingEncryptionAlgorithmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataMaskingEncryptionAlgorithmWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets column encryption permissions for database accounts in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the same column encryption access permissions for a batch of database accounts. UserList can contain accounts from different instances under the same product and region. Each entry must include InstanceId and AccountId. fullAccess allows plaintext access, restrictedAccess allows restricted access, and noneAccess denies decryption and is supported only for specific DPI engines and key patterns. Only fullAccess supports configuring a validity period. After a successful request, invoke ListDataAssetAccounts to verify the results.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, for example, cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. A successful request does not indicate that the operation is complete. Verify the status by invoking the corresponding query operation as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataMaskingUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataMaskingUsersResponse
        /// </returns>
        public UpdateDataMaskingUsersResponse UpdateDataMaskingUsersWithOptions(UpdateDataMaskingUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataMaskingUsersShrinkRequest request = new UpdateDataMaskingUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserList))
            {
                request.UserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserList, "UserList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthRole))
            {
                query["AuthRole"] = request.AuthRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeOperation))
            {
                query["ExpireTimeOperation"] = request.ExpireTimeOperation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserListShrink))
            {
                query["UserList"] = request.UserListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataMaskingUsers",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataMaskingUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets column encryption permissions for database accounts in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the same column encryption access permissions for a batch of database accounts. UserList can contain accounts from different instances under the same product and region. Each entry must include InstanceId and AccountId. fullAccess allows plaintext access, restrictedAccess allows restricted access, and noneAccess denies decryption and is supported only for specific DPI engines and key patterns. Only fullAccess supports configuring a validity period. After a successful request, invoke ListDataAssetAccounts to verify the results.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, for example, cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. A successful request does not indicate that the operation is complete. Verify the status by invoking the corresponding query operation as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateDataMaskingUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataMaskingUsersResponse
        /// </returns>
        public async Task<UpdateDataMaskingUsersResponse> UpdateDataMaskingUsersWithOptionsAsync(UpdateDataMaskingUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateDataMaskingUsersShrinkRequest request = new UpdateDataMaskingUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserList))
            {
                request.UserListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserList, "UserList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthRole))
            {
                query["AuthRole"] = request.AuthRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                query["ExpireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTimeOperation))
            {
                query["ExpireTimeOperation"] = request.ExpireTimeOperation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserListShrink))
            {
                query["UserList"] = request.UserListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDataMaskingUsers",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataMaskingUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets column encryption permissions for database accounts in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the same column encryption access permissions for a batch of database accounts. UserList can contain accounts from different instances under the same product and region. Each entry must include InstanceId and AccountId. fullAccess allows plaintext access, restrictedAccess allows restricted access, and noneAccess denies decryption and is supported only for specific DPI engines and key patterns. Only fullAccess supports configuring a validity period. After a successful request, invoke ListDataAssetAccounts to verify the results.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, for example, cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. A successful request does not indicate that the operation is complete. Verify the status by invoking the corresponding query operation as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataMaskingUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataMaskingUsersResponse
        /// </returns>
        public UpdateDataMaskingUsersResponse UpdateDataMaskingUsers(UpdateDataMaskingUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataMaskingUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets column encryption permissions for database accounts in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the same column encryption access permissions for a batch of database accounts. UserList can contain accounts from different instances under the same product and region. Each entry must include InstanceId and AccountId. fullAccess allows plaintext access, restrictedAccess allows restricted access, and noneAccess denies decryption and is supported only for specific DPI engines and key patterns. Only fullAccess supports configuring a validity period. After a successful request, invoke ListDataAssetAccounts to verify the results.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identities, and configuration values obtained from your account.
        /// Use the endpoint of the region where the target asset resides and set the common parameter RegionId, for example, cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. A successful request does not indicate that the operation is complete. Verify the status by invoking the corresponding query operation as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateDataMaskingUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataMaskingUsersResponse
        /// </returns>
        public async Task<UpdateDataMaskingUsersResponse> UpdateDataMaskingUsersAsync(UpdateDataMaskingUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataMaskingUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the database kernel of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upgrades the database kernel of a specified instance at the selected time. Invoke ListMiniEngineVersions first to select a version, and check the current instance status and maintenance window. SpecifyTime requires a future SwitchTime value. PolarDB-X 2.0 does not support this time option. The upgrade is an asynchronous operation. Read back the CurrentKernelVersion field from GetInstanceAttribute to verify the result.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and configure the common parameter RegionId to the corresponding value, for example, cn-zhangjiakou. The product code and instance identity must match the target asset.
        /// This operation returns only a RequestId. A successful request does not mean the operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeKernelVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeKernelVersionResponse
        /// </returns>
        public UpgradeKernelVersionResponse UpgradeKernelVersionWithOptions(UpgradeKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KernelVersion))
            {
                query["KernelVersion"] = request.KernelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTime))
            {
                query["SwitchTime"] = request.SwitchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeTime))
            {
                query["UpgradeTime"] = request.UpgradeTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeKernelVersion",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeKernelVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the database kernel of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upgrades the database kernel of a specified instance at the selected time. Invoke ListMiniEngineVersions first to select a version, and check the current instance status and maintenance window. SpecifyTime requires a future SwitchTime value. PolarDB-X 2.0 does not support this time option. The upgrade is an asynchronous operation. Read back the CurrentKernelVersion field from GetInstanceAttribute to verify the result.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and configure the common parameter RegionId to the corresponding value, for example, cn-zhangjiakou. The product code and instance identity must match the target asset.
        /// This operation returns only a RequestId. A successful request does not mean the operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeKernelVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeKernelVersionResponse
        /// </returns>
        public async Task<UpgradeKernelVersionResponse> UpgradeKernelVersionWithOptionsAsync(UpgradeKernelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KernelVersion))
            {
                query["KernelVersion"] = request.KernelVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["ProductId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchTime))
            {
                query["SwitchTime"] = request.SwitchTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpgradeTime))
            {
                query["UpgradeTime"] = request.UpgradeTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeKernelVersion",
                Version = "2026-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeKernelVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the database kernel of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upgrades the database kernel of a specified instance at the selected time. Invoke ListMiniEngineVersions first to select a version, and check the current instance status and maintenance window. SpecifyTime requires a future SwitchTime value. PolarDB-X 2.0 does not support this time option. The upgrade is an asynchronous operation. Read back the CurrentKernelVersion field from GetInstanceAttribute to verify the result.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and configure the common parameter RegionId to the corresponding value, for example, cn-zhangjiakou. The product code and instance identity must match the target asset.
        /// This operation returns only a RequestId. A successful request does not mean the operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeKernelVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeKernelVersionResponse
        /// </returns>
        public UpgradeKernelVersionResponse UpgradeKernelVersion(UpgradeKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeKernelVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the database kernel of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Upgrades the database kernel of a specified instance at the selected time. Invoke ListMiniEngineVersions first to select a version, and check the current instance status and maintenance window. SpecifyTime requires a future SwitchTime value. PolarDB-X 2.0 does not support this time option. The upgrade is an asynchronous operation. Read back the CurrentKernelVersion field from GetInstanceAttribute to verify the result.
        /// The parameter examples are provided only to illustrate the format. Replace them with the region, resource identity, and configuration values obtained from your current account.
        /// Use the service registration endpoint of the region where the target asset resides, and configure the common parameter RegionId to the corresponding value, for example, cn-zhangjiakou. The product code and instance identity must match the target asset.
        /// This operation returns only a RequestId. A successful request does not mean the operation is complete. Read back the status as described in the operation description.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeKernelVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeKernelVersionResponse
        /// </returns>
        public async Task<UpgradeKernelVersionResponse> UpgradeKernelVersionAsync(UpgradeKernelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeKernelVersionWithOptionsAsync(request, runtime);
        }

    }
}
