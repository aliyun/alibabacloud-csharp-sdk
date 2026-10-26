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
        /// <para>Checks the permissions, DPI engine, and running conditions of an instance before you create column encryption. You must check both ErrorCode and ErrorMessage in the response. Only ErrorCode=Success indicates that the check is passed. A successful request does not mean that the instance meets all encryption conditions. This check does not create a column encryption rule.
        /// Parameter examples are for format illustration only. When you invoke the operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Checks the permissions, DPI engine, and running conditions of an instance before you create column encryption. You must check both ErrorCode and ErrorMessage in the response. Only ErrorCode=Success indicates that the check is passed. A successful request does not mean that the instance meets all encryption conditions. This check does not create a column encryption rule.
        /// Parameter examples are for format illustration only. When you invoke the operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Checks the permissions, DPI engine, and running conditions of an instance before you create column encryption. You must check both ErrorCode and ErrorMessage in the response. Only ErrorCode=Success indicates that the check is passed. A successful request does not mean that the instance meets all encryption conditions. This check does not create a column encryption rule.
        /// Parameter examples are for format illustration only. When you invoke the operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Checks the permissions, DPI engine, and running conditions of an instance before you create column encryption. You must check both ErrorCode and ErrorMessage in the response. Only ErrorCode=Success indicates that the check is passed. A successful request does not mean that the instance meets all encryption conditions. This check does not create a column encryption rule.
        /// Parameter examples are for format illustration only. When you invoke the operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Creates a column encryption rule for specified databases, tables, and columns under the same instance. Before calling this operation, check the instance status, supported algorithms, keys, target columns, and accounts. SubRuleList is a list of targets grouped by table, and Columns is a string of column names separated by commas. Accounts in UserList are granted the fullAccess plaintext permission. A successful request only indicates that the request is accepted. You must call the ListDataMaskingColumns and ListDataAssetAccounts operations to confirm the column status, account permissions, and validity period.
        /// The parameter examples are for illustrative purposes only. When calling this operation, replace them with the region, resource identifiers, and configuration values obtained by querying the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match those of the target asset.
        /// This operation only returns RequestId. Request acceptance does not mean that the business operation is complete. Read back the status as described in the operation description.</para>
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
        /// <para>Creates a column encryption rule for specified databases, tables, and columns under the same instance. Before calling this operation, check the instance status, supported algorithms, keys, target columns, and accounts. SubRuleList is a list of targets grouped by table, and Columns is a string of column names separated by commas. Accounts in UserList are granted the fullAccess plaintext permission. A successful request only indicates that the request is accepted. You must call the ListDataMaskingColumns and ListDataAssetAccounts operations to confirm the column status, account permissions, and validity period.
        /// The parameter examples are for illustrative purposes only. When calling this operation, replace them with the region, resource identifiers, and configuration values obtained by querying the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match those of the target asset.
        /// This operation only returns RequestId. Request acceptance does not mean that the business operation is complete. Read back the status as described in the operation description.</para>
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
        /// <para>Creates a column encryption rule for specified databases, tables, and columns under the same instance. Before calling this operation, check the instance status, supported algorithms, keys, target columns, and accounts. SubRuleList is a list of targets grouped by table, and Columns is a string of column names separated by commas. Accounts in UserList are granted the fullAccess plaintext permission. A successful request only indicates that the request is accepted. You must call the ListDataMaskingColumns and ListDataAssetAccounts operations to confirm the column status, account permissions, and validity period.
        /// The parameter examples are for illustrative purposes only. When calling this operation, replace them with the region, resource identifiers, and configuration values obtained by querying the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match those of the target asset.
        /// This operation only returns RequestId. Request acceptance does not mean that the business operation is complete. Read back the status as described in the operation description.</para>
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
        /// <para>Creates a column encryption rule for specified databases, tables, and columns under the same instance. Before calling this operation, check the instance status, supported algorithms, keys, target columns, and accounts. SubRuleList is a list of targets grouped by table, and Columns is a string of column names separated by commas. Accounts in UserList are granted the fullAccess plaintext permission. A successful request only indicates that the request is accepted. You must call the ListDataMaskingColumns and ListDataAssetAccounts operations to confirm the column status, account permissions, and validity period.
        /// The parameter examples are for illustrative purposes only. When calling this operation, replace them with the region, resource identifiers, and configuration values obtained by querying the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match those of the target asset.
        /// This operation only returns RequestId. Request acceptance does not mean that the business operation is complete. Read back the status as described in the operation description.</para>
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
        /// <para>Disables encryption rules for specified columns in the same instance. SubRuleList precisely specifies databases, tables, and columns. If no rule is matched, no new operation object is created. The disable request is processed asynchronously. Use ListDataMaskingColumns to verify that the column is restored to NotEncrypted or that the target rule has been removed. DeleteFailed indicates that the disable operation failed.
        /// The parameter examples are for format illustration only. When you invoke the API, replace them with the region, resource identifier, and configuration values obtained for the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not mean that the business operation is complete. You should check the status as described in the operation description.</para>
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
        /// <para>Disables encryption rules for specified columns in the same instance. SubRuleList precisely specifies databases, tables, and columns. If no rule is matched, no new operation object is created. The disable request is processed asynchronously. Use ListDataMaskingColumns to verify that the column is restored to NotEncrypted or that the target rule has been removed. DeleteFailed indicates that the disable operation failed.
        /// The parameter examples are for format illustration only. When you invoke the API, replace them with the region, resource identifier, and configuration values obtained for the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not mean that the business operation is complete. You should check the status as described in the operation description.</para>
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
        /// <para>Disables encryption rules for specified columns in the same instance. SubRuleList precisely specifies databases, tables, and columns. If no rule is matched, no new operation object is created. The disable request is processed asynchronously. Use ListDataMaskingColumns to verify that the column is restored to NotEncrypted or that the target rule has been removed. DeleteFailed indicates that the disable operation failed.
        /// The parameter examples are for format illustration only. When you invoke the API, replace them with the region, resource identifier, and configuration values obtained for the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not mean that the business operation is complete. You should check the status as described in the operation description.</para>
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
        /// <para>Disables encryption rules for specified columns in the same instance. SubRuleList precisely specifies databases, tables, and columns. If no rule is matched, no new operation object is created. The disable request is processed asynchronously. Use ListDataMaskingColumns to verify that the column is restored to NotEncrypted or that the target rule has been removed. DeleteFailed indicates that the disable operation failed.
        /// The parameter examples are for format illustration only. When you invoke the API, replace them with the region, resource identifier, and configuration values obtained for the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identifier must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not mean that the business operation is complete. You should check the status as described in the operation description.</para>
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
        /// <para>Queries the statistics of account permissions for column encryption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the permission statistics of database accounts in the current region by product scope. Plaintext accounts correspond to FullAccessCount. Restricted access and decryption-prohibited accounts are counted in RestrictedAccessCount and NoneAccessCount, respectively. The number of accounts without configured permissions can be obtained by subtracting the number of the preceding three types of accounts from TotalCount. This operation does not accept filter conditions such as instance, database, table, or column.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke this operation.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must be consistent with the target asset.</para>
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
        /// <para>Queries the statistics of account permissions for column encryption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the permission statistics of database accounts in the current region by product scope. Plaintext accounts correspond to FullAccessCount. Restricted access and decryption-prohibited accounts are counted in RestrictedAccessCount and NoneAccessCount, respectively. The number of accounts without configured permissions can be obtained by subtracting the number of the preceding three types of accounts from TotalCount. This operation does not accept filter conditions such as instance, database, table, or column.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke this operation.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must be consistent with the target asset.</para>
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
        /// <para>Queries the statistics of account permissions for column encryption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the permission statistics of database accounts in the current region by product scope. Plaintext accounts correspond to FullAccessCount. Restricted access and decryption-prohibited accounts are counted in RestrictedAccessCount and NoneAccessCount, respectively. The number of accounts without configured permissions can be obtained by subtracting the number of the preceding three types of accounts from TotalCount. This operation does not accept filter conditions such as instance, database, table, or column.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke this operation.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must be consistent with the target asset.</para>
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
        /// <para>Queries the statistics of account permissions for column encryption.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the permission statistics of database accounts in the current region by product scope. Plaintext accounts correspond to FullAccessCount. Restricted access and decryption-prohibited accounts are counted in RestrictedAccessCount and NoneAccessCount, respectively. The number of accounts without configured permissions can be obtained by subtracting the number of the preceding three types of accounts from TotalCount. This operation does not accept filter conditions such as instance, database, table, or column.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke this operation.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must be consistent with the target asset.</para>
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
        /// <para>Queries the statistics on the number of encrypted columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the total number of columns, the number of sensitive columns, the number of encrypted columns, and the number of columns that failed to be encrypted by region, product, and categorization and classification template. This operation returns data for statistics cards and does not filter by instance, database name, table name, column name, or model in the column list.
        /// To be compatible with historical detection results, if the specified template has no first-screen results and is not filtered by sensitivity level or detection model, the results may backoff to the built-in general detection results. If strict template attribution is required, use the level or model conditions within the template for verification.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located and apply the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the statistics on the number of encrypted columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the total number of columns, the number of sensitive columns, the number of encrypted columns, and the number of columns that failed to be encrypted by region, product, and categorization and classification template. This operation returns data for statistics cards and does not filter by instance, database name, table name, column name, or model in the column list.
        /// To be compatible with historical detection results, if the specified template has no first-screen results and is not filtered by sensitivity level or detection model, the results may backoff to the built-in general detection results. If strict template attribution is required, use the level or model conditions within the template for verification.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located and apply the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the statistics on the number of encrypted columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the total number of columns, the number of sensitive columns, the number of encrypted columns, and the number of columns that failed to be encrypted by region, product, and categorization and classification template. This operation returns data for statistics cards and does not filter by instance, database name, table name, column name, or model in the column list.
        /// To be compatible with historical detection results, if the specified template has no first-screen results and is not filtered by sensitivity level or detection model, the results may backoff to the built-in general detection results. If strict template attribution is required, use the level or model conditions within the template for verification.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located and apply the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the statistics on the number of encrypted columns.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the total number of columns, the number of sensitive columns, the number of encrypted columns, and the number of columns that failed to be encrypted by region, product, and categorization and classification template. This operation returns data for statistics cards and does not filter by instance, database name, table name, column name, or model in the column list.
        /// To be compatible with historical detection results, if the specified template has no first-screen results and is not filtered by sensitivity level or detection model, the results may backoff to the built-in general detection results. If strict template attribution is required, use the level or model conditions within the template for verification.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located and apply the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the engine and kernel attributes of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the instance engine, current kernel version, maintenance window, and KMS encryption support. After a kernel upgrade, you can read back CurrentKernelVersion to verify the target version. If ErrorCode or ErrorMessage is present, handle the property query exception first.
        /// Parameter examples are for format illustration only. When you call the API, replace them with the region, resource ID, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the engine and kernel attributes of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the instance engine, current kernel version, maintenance window, and KMS encryption support. After a kernel upgrade, you can read back CurrentKernelVersion to verify the target version. If ErrorCode or ErrorMessage is present, handle the property query exception first.
        /// Parameter examples are for format illustration only. When you call the API, replace them with the region, resource ID, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the engine and kernel attributes of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the instance engine, current kernel version, maintenance window, and KMS encryption support. After a kernel upgrade, you can read back CurrentKernelVersion to verify the target version. If ErrorCode or ErrorMessage is present, handle the property query exception first.
        /// Parameter examples are for format illustration only. When you call the API, replace them with the region, resource ID, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the engine and kernel attributes of an instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the instance engine, current kernel version, maintenance window, and KMS encryption support. After a kernel upgrade, you can read back CurrentKernelVersion to verify the target version. If ErrorCode or ErrorMessage is present, handle the property query exception first.
        /// Parameter examples are for format illustration only. When you call the API, replace them with the region, resource ID, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the columns and detection results of a data table.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on the columns and detection results in a data table. If both DataAssetSourceId and InstanceName are specified, DataAssetSourceId takes precedence. In PostgreSQL and Oracle scenarios, you can use the schema.table format for TableName and pass the corresponding EngineType. To query the execution status of column encryption, call ListDataMaskingColumns.
        /// To ensure compatibility with historical detection results, if the specified template has no first-screen results and is not filtered by sensitivity level or detection model, the results may fall back to the built-in general detection results. If strict template attribution is required, use the level or model conditions within the template for verification.
        /// The parameter examples are for format illustration only. When you call the API, replace them with the region, resource identifier, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
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
        /// <para>Queries the columns and detection results of a data table.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on the columns and detection results in a data table. If both DataAssetSourceId and InstanceName are specified, DataAssetSourceId takes precedence. In PostgreSQL and Oracle scenarios, you can use the schema.table format for TableName and pass the corresponding EngineType. To query the execution status of column encryption, call ListDataMaskingColumns.
        /// To ensure compatibility with historical detection results, if the specified template has no first-screen results and is not filtered by sensitivity level or detection model, the results may fall back to the built-in general detection results. If strict template attribution is required, use the level or model conditions within the template for verification.
        /// The parameter examples are for format illustration only. When you call the API, replace them with the region, resource identifier, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
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
        /// <para>Queries the columns and detection results of a data table.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on the columns and detection results in a data table. If both DataAssetSourceId and InstanceName are specified, DataAssetSourceId takes precedence. In PostgreSQL and Oracle scenarios, you can use the schema.table format for TableName and pass the corresponding EngineType. To query the execution status of column encryption, call ListDataMaskingColumns.
        /// To ensure compatibility with historical detection results, if the specified template has no first-screen results and is not filtered by sensitivity level or detection model, the results may fall back to the built-in general detection results. If strict template attribution is required, use the level or model conditions within the template for verification.
        /// The parameter examples are for format illustration only. When you call the API, replace them with the region, resource identifier, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
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
        /// <para>Queries the columns and detection results of a data table.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on the columns and detection results in a data table. If both DataAssetSourceId and InstanceName are specified, DataAssetSourceId takes precedence. In PostgreSQL and Oracle scenarios, you can use the schema.table format for TableName and pass the corresponding EngineType. To query the execution status of column encryption, call ListDataMaskingColumns.
        /// To ensure compatibility with historical detection results, if the specified template has no first-screen results and is not filtered by sensitivity level or detection model, the results may fall back to the built-in general detection results. If strict template attribution is required, use the level or model conditions within the template for verification.
        /// The parameter examples are for format illustration only. When you call the API, replace them with the region, resource identifier, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance identity must match the target asset.</para>
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
        /// <para>Uses paging to query database accounts and their column encryption access permissions. This operation is used to select plaintext accounts when creating rules, and to verify AuthRole, EncryptionKeyMode, and ExpireTime before and after modifying account permissions. AccountName filters accounts by exact account name, and the account ID is obtained from Items[].Id.
        /// The parameter examples are for format illustration only. Replace them with the region, resource IDs, and configuration values obtained from the current account when you call the operation.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthDb))
            {
                query["AuthDb"] = request.AuthDb;
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
        /// <para>Uses paging to query database accounts and their column encryption access permissions. This operation is used to select plaintext accounts when creating rules, and to verify AuthRole, EncryptionKeyMode, and ExpireTime before and after modifying account permissions. AccountName filters accounts by exact account name, and the account ID is obtained from Items[].Id.
        /// The parameter examples are for format illustration only. Replace them with the region, resource IDs, and configuration values obtained from the current account when you call the operation.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthDb))
            {
                query["AuthDb"] = request.AuthDb;
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
        /// <para>Uses paging to query database accounts and their column encryption access permissions. This operation is used to select plaintext accounts when creating rules, and to verify AuthRole, EncryptionKeyMode, and ExpireTime before and after modifying account permissions. AccountName filters accounts by exact account name, and the account ID is obtained from Items[].Id.
        /// The parameter examples are for format illustration only. Replace them with the region, resource IDs, and configuration values obtained from the current account when you call the operation.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Uses paging to query database accounts and their column encryption access permissions. This operation is used to select plaintext accounts when creating rules, and to verify AuthRole, EncryptionKeyMode, and ExpireTime before and after modifying account permissions. AccountName filters accounts by exact account name, and the account ID is obtained from Items[].Id.
        /// The parameter examples are for format illustration only. Replace them with the region, resource IDs, and configuration values obtained from the current account when you call the operation.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the column encryption status and detection results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query on columns and their encryption status, sensitivity levels, and detection models. Supports paging and combined filtering by template, product, instance, database, table, column name, model, and sensitivity level. Use this operation to read back data after the creation or shutdown of a rule. Processing and Deleting are intermediate states, while Failed and DeleteFailed indicate operation failures. The capitalization of the RiskLeveLId parameter name must be preserved exactly as is.
        /// When querying by product, use a single ProductId or the corresponding ProductCode. The current column query cannot rely on ProductIds to filter multiple products. Query each product separately.
        /// To ensure compatibility with historical detection results, if the specified template yields no initial results and is not filtered by sensitivity level or detection model, the results may fall back to the built-in general detection results. To strictly verify template attribution, use the level or model conditions within the template simultaneously.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identifiers, and configuration values obtained from the current account when making a call.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the column encryption status and detection results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query on columns and their encryption status, sensitivity levels, and detection models. Supports paging and combined filtering by template, product, instance, database, table, column name, model, and sensitivity level. Use this operation to read back data after the creation or shutdown of a rule. Processing and Deleting are intermediate states, while Failed and DeleteFailed indicate operation failures. The capitalization of the RiskLeveLId parameter name must be preserved exactly as is.
        /// When querying by product, use a single ProductId or the corresponding ProductCode. The current column query cannot rely on ProductIds to filter multiple products. Query each product separately.
        /// To ensure compatibility with historical detection results, if the specified template yields no initial results and is not filtered by sensitivity level or detection model, the results may fall back to the built-in general detection results. To strictly verify template attribution, use the level or model conditions within the template simultaneously.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identifiers, and configuration values obtained from the current account when making a call.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the column encryption status and detection results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query on columns and their encryption status, sensitivity levels, and detection models. Supports paging and combined filtering by template, product, instance, database, table, column name, model, and sensitivity level. Use this operation to read back data after the creation or shutdown of a rule. Processing and Deleting are intermediate states, while Failed and DeleteFailed indicate operation failures. The capitalization of the RiskLeveLId parameter name must be preserved exactly as is.
        /// When querying by product, use a single ProductId or the corresponding ProductCode. The current column query cannot rely on ProductIds to filter multiple products. Query each product separately.
        /// To ensure compatibility with historical detection results, if the specified template yields no initial results and is not filtered by sensitivity level or detection model, the results may fall back to the built-in general detection results. To strictly verify template attribution, use the level or model conditions within the template simultaneously.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identifiers, and configuration values obtained from the current account when making a call.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the column encryption status and detection results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query on columns and their encryption status, sensitivity levels, and detection models. Supports paging and combined filtering by template, product, instance, database, table, column name, model, and sensitivity level. Use this operation to read back data after the creation or shutdown of a rule. Processing and Deleting are intermediate states, while Failed and DeleteFailed indicate operation failures. The capitalization of the RiskLeveLId parameter name must be preserved exactly as is.
        /// When querying by product, use a single ProductId or the corresponding ProductCode. The current column query cannot rely on ProductIds to filter multiple products. Query each product separately.
        /// To ensure compatibility with historical detection results, if the specified template yields no initial results and is not filtered by sensitivity level or detection model, the results may fall back to the built-in general detection results. To strictly verify template attribution, use the level or model conditions within the template simultaneously.
        /// Parameter examples are for format illustration only. Replace them with the region, resource identifiers, and configuration values obtained from the current account when making a call.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the available column encryption algorithms for a specified instance and the reasons for any restrictions on each algorithm. Before selecting an algorithm, check the ErrorCode and ErrorMessage of the corresponding item. Do not assume that all instances support the same set of algorithms.
        /// Parameter examples are for format illustration only. When you invoke the API, replace them with the region, resource IDs, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the available column encryption algorithms for a specified instance and the reasons for any restrictions on each algorithm. Before selecting an algorithm, check the ErrorCode and ErrorMessage of the corresponding item. Do not assume that all instances support the same set of algorithms.
        /// Parameter examples are for format illustration only. When you invoke the API, replace them with the region, resource IDs, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the available column encryption algorithms for a specified instance and the reasons for any restrictions on each algorithm. Before selecting an algorithm, check the ErrorCode and ErrorMessage of the corresponding item. Do not assume that all instances support the same set of algorithms.
        /// Parameter examples are for format illustration only. When you invoke the API, replace them with the region, resource IDs, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the available column encryption algorithms for a specified instance and the reasons for any restrictions on each algorithm. Before selecting an algorithm, check the ErrorCode and ErrorMessage of the corresponding item. Do not assume that all instances support the same set of algorithms.
        /// Parameter examples are for format illustration only. When you invoke the API, replace them with the region, resource IDs, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries column-encrypted instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query of column encryption instances, and supports filtering by conditions such as product, detect template, database, table, and column. The scope of instance-level status filtering differs from that of column-level status filtering. To find all unencrypted sensitive columns, first enumerate the instances of the target product, and then use ListDataMaskingColumns to filter by NotEncrypted to avoid missing partially encrypted instances.
        /// When you need to filter precisely by EngineType, read all candidates by paging and then filter by the returned values. This parameter is not applied in some query paths. The matching semantics of InstanceId vary with query combinations. For precise positioning, verify the complete instance identity returned.
        /// Parameter examples are for format illustration only. When you invoke the operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries column-encrypted instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query of column encryption instances, and supports filtering by conditions such as product, detect template, database, table, and column. The scope of instance-level status filtering differs from that of column-level status filtering. To find all unencrypted sensitive columns, first enumerate the instances of the target product, and then use ListDataMaskingColumns to filter by NotEncrypted to avoid missing partially encrypted instances.
        /// When you need to filter precisely by EngineType, read all candidates by paging and then filter by the returned values. This parameter is not applied in some query paths. The matching semantics of InstanceId vary with query combinations. For precise positioning, verify the complete instance identity returned.
        /// Parameter examples are for format illustration only. When you invoke the operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries column-encrypted instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query of column encryption instances, and supports filtering by conditions such as product, detect template, database, table, and column. The scope of instance-level status filtering differs from that of column-level status filtering. To find all unencrypted sensitive columns, first enumerate the instances of the target product, and then use ListDataMaskingColumns to filter by NotEncrypted to avoid missing partially encrypted instances.
        /// When you need to filter precisely by EngineType, read all candidates by paging and then filter by the returned values. This parameter is not applied in some query paths. The matching semantics of InstanceId vary with query combinations. For precise positioning, verify the complete instance identity returned.
        /// Parameter examples are for format illustration only. When you invoke the operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries column-encrypted instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query of column encryption instances, and supports filtering by conditions such as product, detect template, database, table, and column. The scope of instance-level status filtering differs from that of column-level status filtering. To find all unencrypted sensitive columns, first enumerate the instances of the target product, and then use ListDataMaskingColumns to filter by NotEncrypted to avoid missing partially encrypted instances.
        /// When you need to filter precisely by EngineType, read all candidates by paging and then filter by the returned values. This parameter is not applied in some query paths. The matching semantics of InstanceId vary with query combinations. For precise positioning, verify the complete instance identity returned.
        /// Parameter examples are for format illustration only. When you invoke the operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the recognition models in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the valid recognition models in a specified template and returns RuleList. If TemplateId is not specified, the currently enabled template is used. The model ID is obtained from RuleList[].Id and can be used to filter TemplateRuleIds.
        /// Parameter examples are provided only to illustrate the format. When you call the API, replace them with the region, resource IDs, and configuration values queried from the current account.</para>
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
        /// <para>Queries the recognition models in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the valid recognition models in a specified template and returns RuleList. If TemplateId is not specified, the currently enabled template is used. The model ID is obtained from RuleList[].Id and can be used to filter TemplateRuleIds.
        /// Parameter examples are provided only to illustrate the format. When you call the API, replace them with the region, resource IDs, and configuration values queried from the current account.</para>
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
        /// <para>Queries the recognition models in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the valid recognition models in a specified template and returns RuleList. If TemplateId is not specified, the currently enabled template is used. The model ID is obtained from RuleList[].Id and can be used to filter TemplateRuleIds.
        /// Parameter examples are provided only to illustrate the format. When you call the API, replace them with the region, resource IDs, and configuration values queried from the current account.</para>
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
        /// <para>Queries the recognition models in a template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the valid recognition models in a specified template and returns RuleList. If TemplateId is not specified, the currently enabled template is used. The model ID is obtained from RuleList[].Id and can be used to filter TemplateRuleIds.
        /// Parameter examples are provided only to illustrate the format. When you call the API, replace them with the region, resource IDs, and configuration values queried from the current account.</para>
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
        /// <para>Queries the KMS key identities and aliases available for the column encryption configuration of a specified instance. Before using a KMS key, verify the key status and usage conditions by calling the DescribeKey operation of KMS. This operation does not return the plaintext of the key.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the KMS key identities and aliases available for the column encryption configuration of a specified instance. Before using a KMS key, verify the key status and usage conditions by calling the DescribeKey operation of KMS. This operation does not return the plaintext of the key.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the KMS key identities and aliases available for the column encryption configuration of a specified instance. Before using a KMS key, verify the key status and usage conditions by calling the DescribeKey operation of KMS. This operation does not return the plaintext of the key.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the KMS key identities and aliases available for the column encryption configuration of a specified instance. Before using a KMS key, verify the key status and usage conditions by calling the DescribeKey operation of KMS. This operation does not return the plaintext of the key.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the upgradable kernel versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available kernel versions for an instance. For an upgrade, select the target version from KernelVersions[].KernelVersion. Do not manually construct the version number.
        /// Parameter examples are for format illustration only. When you call the API, replace them with the region, resource ID, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the upgradable kernel versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available kernel versions for an instance. For an upgrade, select the target version from KernelVersions[].KernelVersion. Do not manually construct the version number.
        /// Parameter examples are for format illustration only. When you call the API, replace them with the region, resource ID, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the upgradable kernel versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available kernel versions for an instance. For an upgrade, select the target version from KernelVersions[].KernelVersion. Do not manually construct the version number.
        /// Parameter examples are for format illustration only. When you call the API, replace them with the region, resource ID, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the upgradable kernel versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the available kernel versions for an instance. For an upgrade, select the target version from KernelVersions[].KernelVersion. Do not manually construct the version number.
        /// Parameter examples are for format illustration only. When you call the API, replace them with the region, resource ID, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset is located, and set the common parameter RegionId, such as cn-zhangjiakou. The product code and instance ID must match the target asset.</para>
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
        /// <para>Queries the regions where assets are located.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of regions where the assets owned by the current account are located. You can use this list to select the RegionId for subsequent region-specific API operations. You can filter the regions based on whether auditing or detection is enabled. The returned region list is not the same as the list of all regions supported by Alibaba Cloud services.
        /// The parameter examples are for format illustration only. When you call this operation, replace them with the regions, resource identifiers, and configuration values queried from the current account.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadAll))
            {
                query["LoadAll"] = request.LoadAll;
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
        /// <para>Queries the regions where assets are located.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of regions where the assets owned by the current account are located. You can use this list to select the RegionId for subsequent region-specific API operations. You can filter the regions based on whether auditing or detection is enabled. The returned region list is not the same as the list of all regions supported by Alibaba Cloud services.
        /// The parameter examples are for format illustration only. When you call this operation, replace them with the regions, resource identifiers, and configuration values queried from the current account.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadAll))
            {
                query["LoadAll"] = request.LoadAll;
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
        /// <para>Queries the regions where assets are located.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of regions where the assets owned by the current account are located. You can use this list to select the RegionId for subsequent region-specific API operations. You can filter the regions based on whether auditing or detection is enabled. The returned region list is not the same as the list of all regions supported by Alibaba Cloud services.
        /// The parameter examples are for format illustration only. When you call this operation, replace them with the regions, resource identifiers, and configuration values queried from the current account.</para>
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
        /// <para>Queries the regions where assets are located.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the list of regions where the assets owned by the current account are located. You can use this list to select the RegionId for subsequent region-specific API operations. You can filter the regions based on whether auditing or detection is enabled. The returned region list is not the same as the list of all regions supported by Alibaba Cloud services.
        /// The parameter examples are for format illustration only. When you call this operation, replace them with the regions, resource identifiers, and configuration values queried from the current account.</para>
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
        /// <para>Queries the sensitivity levels in a data classification template. Pass the level ID in subsequent queries. Do not use level names such as S1 or S2 directly as RiskLevelId.
        /// The parameter examples are for format illustration only. When calling the API, replace them with the region, resource identifiers, and configuration values obtained for the current account.</para>
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
        /// <para>Queries the sensitivity levels in a data classification template. Pass the level ID in subsequent queries. Do not use level names such as S1 or S2 directly as RiskLevelId.
        /// The parameter examples are for format illustration only. When calling the API, replace them with the region, resource identifiers, and configuration values obtained for the current account.</para>
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
        /// <para>Queries the sensitivity levels in a data classification template. Pass the level ID in subsequent queries. Do not use level names such as S1 or S2 directly as RiskLevelId.
        /// The parameter examples are for format illustration only. When calling the API, replace them with the region, resource identifiers, and configuration values obtained for the current account.</para>
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
        /// <para>Queries the sensitivity levels in a data classification template. Pass the level ID in subsequent queries. Do not use level names such as S1 or S2 directly as RiskLevelId.
        /// The parameter examples are for format illustration only. When calling the API, replace them with the region, resource identifiers, and configuration values obtained for the current account.</para>
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
        /// <para>Queries database tables and detection results in a database by using paging. For relational databases, set DataAssetSourceId to the instance identity and DataSourceName to the database name. Table names in PostgreSQL and Oracle may contain a schema prefix. Pass the table name as is for subsequent column queries.
        /// To be compatible with historical detection results, if the specified template yields no initial results and no filtering is applied by sensitivity level or detection model, the results may fall back to the built-in general detection results. To strictly verify template attribution, use the level or model conditions within the template at the same time.
        /// The parameter examples are provided only to illustrate the format. When you invoke the API, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries database tables and detection results in a database by using paging. For relational databases, set DataAssetSourceId to the instance identity and DataSourceName to the database name. Table names in PostgreSQL and Oracle may contain a schema prefix. Pass the table name as is for subsequent column queries.
        /// To be compatible with historical detection results, if the specified template yields no initial results and no filtering is applied by sensitivity level or detection model, the results may fall back to the built-in general detection results. To strictly verify template attribution, use the level or model conditions within the template at the same time.
        /// The parameter examples are provided only to illustrate the format. When you invoke the API, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries database tables and detection results in a database by using paging. For relational databases, set DataAssetSourceId to the instance identity and DataSourceName to the database name. Table names in PostgreSQL and Oracle may contain a schema prefix. Pass the table name as is for subsequent column queries.
        /// To be compatible with historical detection results, if the specified template yields no initial results and no filtering is applied by sensitivity level or detection model, the results may fall back to the built-in general detection results. To strictly verify template attribution, use the level or model conditions within the template at the same time.
        /// The parameter examples are provided only to illustrate the format. When you invoke the API, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries database tables and detection results in a database by using paging. For relational databases, set DataAssetSourceId to the instance identity and DataSourceName to the database name. Table names in PostgreSQL and Oracle may contain a schema prefix. Pass the table name as is for subsequent column queries.
        /// To be compatible with historical detection results, if the specified template yields no initial results and no filtering is applied by sensitivity level or detection model, the results may fall back to the built-in general detection results. To strictly verify template attribution, use the level or model conditions within the template at the same time.
        /// The parameter examples are provided only to illustrate the format. When you invoke the API, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the endpoint of the region where the target asset resides, and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.</para>
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
        /// <para>Queries the classification and grading templates available for the current account. Use Items[].Id as the TemplateId for subsequent API operations. The detection model and sensitivity level must belong to the same template. Parameter examples are for format illustration only. Replace them with the region, resource identifiers, and configuration values obtained from the current account when making the call.</para>
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
        /// <para>Queries the classification and grading templates available for the current account. Use Items[].Id as the TemplateId for subsequent API operations. The detection model and sensitivity level must belong to the same template. Parameter examples are for format illustration only. Replace them with the region, resource identifiers, and configuration values obtained from the current account when making the call.</para>
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
        /// <para>Queries the classification and grading templates available for the current account. Use Items[].Id as the TemplateId for subsequent API operations. The detection model and sensitivity level must belong to the same template. Parameter examples are for format illustration only. Replace them with the region, resource identifiers, and configuration values obtained from the current account when making the call.</para>
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
        /// <para>Queries the classification and grading templates available for the current account. Use Items[].Id as the TemplateId for subsequent API operations. The detection model and sensitivity level must belong to the same template. Parameter examples are for format illustration only. Replace them with the region, resource identifiers, and configuration values obtained from the current account when making the call.</para>
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
        /// <para>Queries the statistics of sensitive data in the overview, data catalog, or aggregated by region. If CountType is set to 41, overview statistics are returned. If CountType is set to 42, data catalog statistics for a specified product are returned. If CountType is set to 43, data aggregated by region and template is returned. The column encryption console uses CountType=43 and ProductCodeList to obtain region and template candidates. The statistics may be derived from generated summary results and do not indicate that a recently initiated synchronization or encryption operation has been completed.
        /// Parameter examples are for format illustration only. When calling the API, replace them with the regions, resource identifiers, and configuration values obtained from the current account.</para>
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
        /// <para>Queries the statistics of sensitive data in the overview, data catalog, or aggregated by region. If CountType is set to 41, overview statistics are returned. If CountType is set to 42, data catalog statistics for a specified product are returned. If CountType is set to 43, data aggregated by region and template is returned. The column encryption console uses CountType=43 and ProductCodeList to obtain region and template candidates. The statistics may be derived from generated summary results and do not indicate that a recently initiated synchronization or encryption operation has been completed.
        /// Parameter examples are for format illustration only. When calling the API, replace them with the regions, resource identifiers, and configuration values obtained from the current account.</para>
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
        /// <para>Queries the statistics of sensitive data in the overview, data catalog, or aggregated by region. If CountType is set to 41, overview statistics are returned. If CountType is set to 42, data catalog statistics for a specified product are returned. If CountType is set to 43, data aggregated by region and template is returned. The column encryption console uses CountType=43 and ProductCodeList to obtain region and template candidates. The statistics may be derived from generated summary results and do not indicate that a recently initiated synchronization or encryption operation has been completed.
        /// Parameter examples are for format illustration only. When calling the API, replace them with the regions, resource identifiers, and configuration values obtained from the current account.</para>
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
        /// <para>Queries the statistics of sensitive data in the overview, data catalog, or aggregated by region. If CountType is set to 41, overview statistics are returned. If CountType is set to 42, data catalog statistics for a specified product are returned. If CountType is set to 43, data aggregated by region and template is returned. The column encryption console uses CountType=43 and ProductCodeList to obtain region and template candidates. The statistics may be derived from generated summary results and do not indicate that a recently initiated synchronization or encryption operation has been completed.
        /// Parameter examples are for format illustration only. When calling the API, replace them with the regions, resource identifiers, and configuration values obtained from the current account.</para>
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
        /// <para>Sets the column encryption permissions for multiple database accounts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the same column encryption access permissions Settings for a batch of database accounts. UserList can contain accounts from different instances under the same product and region. Each item must include InstanceId and AccountId. fullAccess allows plaintext access, restrictedAccess allows restricted access, and noneAccess prohibits decryption and is supported only by specific DPI engines and key patterns. Only fullAccess supports configuring an expiration time. After a successful request, invoke ListDataAssetAccounts to read back the results.
        /// The parameter examples are for format illustration only. When invoking this operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not mean the business operation is complete. You must read back the status as described in the operation description.</para>
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
        /// <para>Sets the column encryption permissions for multiple database accounts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the same column encryption access permissions Settings for a batch of database accounts. UserList can contain accounts from different instances under the same product and region. Each item must include InstanceId and AccountId. fullAccess allows plaintext access, restrictedAccess allows restricted access, and noneAccess prohibits decryption and is supported only by specific DPI engines and key patterns. Only fullAccess supports configuring an expiration time. After a successful request, invoke ListDataAssetAccounts to read back the results.
        /// The parameter examples are for format illustration only. When invoking this operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not mean the business operation is complete. You must read back the status as described in the operation description.</para>
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
        /// <para>Sets the column encryption permissions for multiple database accounts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the same column encryption access permissions Settings for a batch of database accounts. UserList can contain accounts from different instances under the same product and region. Each item must include InstanceId and AccountId. fullAccess allows plaintext access, restrictedAccess allows restricted access, and noneAccess prohibits decryption and is supported only by specific DPI engines and key patterns. Only fullAccess supports configuring an expiration time. After a successful request, invoke ListDataAssetAccounts to read back the results.
        /// The parameter examples are for format illustration only. When invoking this operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not mean the business operation is complete. You must read back the status as described in the operation description.</para>
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
        /// <para>Sets the column encryption permissions for multiple database accounts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sets the same column encryption access permissions Settings for a batch of database accounts. UserList can contain accounts from different instances under the same product and region. Each item must include InstanceId and AccountId. fullAccess allows plaintext access, restrictedAccess allows restricted access, and noneAccess prohibits decryption and is supported only by specific DPI engines and key patterns. Only fullAccess supports configuring an expiration time. After a successful request, invoke ListDataAssetAccounts to read back the results.
        /// The parameter examples are for format illustration only. When invoking this operation, replace them with the region, resource identity, and configuration values obtained from the current account.
        /// Use the service registration endpoint of the region where the target asset is located and set the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Request acceptance does not mean the business operation is complete. You must read back the status as described in the operation description.</para>
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
        /// <para>Upgrades the database kernel of a specified instance at the selected time. Invoke ListMiniEngineVersions to select a version, and check the current status and maintenance window of the instance. SpecifyTime requires a future SwitchTime, and PolarDB-X 2.0 does not support these time options. The upgrade is an asynchronous operation. Invoke GetInstanceAttribute to check the CurrentKernelVersion and verify the result.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Acceptance of the request does not mean the business operation is complete. Check the status as described in the operation description.</para>
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
        /// <para>Upgrades the database kernel of a specified instance at the selected time. Invoke ListMiniEngineVersions to select a version, and check the current status and maintenance window of the instance. SpecifyTime requires a future SwitchTime, and PolarDB-X 2.0 does not support these time options. The upgrade is an asynchronous operation. Invoke GetInstanceAttribute to check the CurrentKernelVersion and verify the result.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Acceptance of the request does not mean the business operation is complete. Check the status as described in the operation description.</para>
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
        /// <para>Upgrades the database kernel of a specified instance at the selected time. Invoke ListMiniEngineVersions to select a version, and check the current status and maintenance window of the instance. SpecifyTime requires a future SwitchTime, and PolarDB-X 2.0 does not support these time options. The upgrade is an asynchronous operation. Invoke GetInstanceAttribute to check the CurrentKernelVersion and verify the result.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Acceptance of the request does not mean the business operation is complete. Check the status as described in the operation description.</para>
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
        /// <para>Upgrades the database kernel of a specified instance at the selected time. Invoke ListMiniEngineVersions to select a version, and check the current status and maintenance window of the instance. SpecifyTime requires a future SwitchTime, and PolarDB-X 2.0 does not support these time options. The upgrade is an asynchronous operation. Invoke GetInstanceAttribute to check the CurrentKernelVersion and verify the result.
        /// The parameter examples are for format illustration only. Replace them with the region, resource identity, and configuration values obtained from the current account when you invoke the operation.
        /// Use the service registration endpoint of the region where the target asset is located, and configure the Settings for the common parameter RegionId, such as cn-zhangjiakou. The product encoding and instance identity must match the target asset.
        /// This operation returns only RequestId. Acceptance of the request does not mean the business operation is complete. Check the status as described in the operation description.</para>
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
