// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Safconsole20250521.Models;

namespace AlibabaCloud.SDK.Safconsole20250521
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("safconsole", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Create basic model information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleBasicInfoResponse
        /// </returns>
        public CreateCustomerModuleBasicInfoResponse CreateCustomerModuleBasicInfoWithOptions(CreateCustomerModuleBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleName))
            {
                query["CustomerModuleName"] = request.CustomerModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                query["ModuleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorePath))
            {
                query["StorePath"] = request.StorePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomerModuleBasicInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerModuleBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create basic model information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleBasicInfoResponse
        /// </returns>
        public async Task<CreateCustomerModuleBasicInfoResponse> CreateCustomerModuleBasicInfoWithOptionsAsync(CreateCustomerModuleBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleName))
            {
                query["CustomerModuleName"] = request.CustomerModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                query["ModuleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorePath))
            {
                query["StorePath"] = request.StorePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomerModuleBasicInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerModuleBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create basic model information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleBasicInfoResponse
        /// </returns>
        public CreateCustomerModuleBasicInfoResponse CreateCustomerModuleBasicInfo(CreateCustomerModuleBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomerModuleBasicInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create basic model information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleBasicInfoResponse
        /// </returns>
        public async Task<CreateCustomerModuleBasicInfoResponse> CreateCustomerModuleBasicInfoAsync(CreateCustomerModuleBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomerModuleBasicInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save Model Feature Configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <list type="bullet">
        /// <item><description>This interface is used to query all available feature templates in the system.</description></item>
        /// <item><description>The request method is GET, and no additional parameters are required.</description></item>
        /// <item><description>The returned result includes multiple feature template options, each option including a label (label) and value (value).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleMetaInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleMetaInfoResponse
        /// </returns>
        public CreateCustomerModuleMetaInfoResponse CreateCustomerModuleMetaInfoWithOptions(CreateCustomerModuleMetaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureString))
            {
                query["FeatureString"] = request.FeatureString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureTemplate))
            {
                query["FeatureTemplate"] = request.FeatureTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomerModuleMetaInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerModuleMetaInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save Model Feature Configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <list type="bullet">
        /// <item><description>This interface is used to query all available feature templates in the system.</description></item>
        /// <item><description>The request method is GET, and no additional parameters are required.</description></item>
        /// <item><description>The returned result includes multiple feature template options, each option including a label (label) and value (value).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleMetaInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleMetaInfoResponse
        /// </returns>
        public async Task<CreateCustomerModuleMetaInfoResponse> CreateCustomerModuleMetaInfoWithOptionsAsync(CreateCustomerModuleMetaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureString))
            {
                query["FeatureString"] = request.FeatureString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureTemplate))
            {
                query["FeatureTemplate"] = request.FeatureTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomerModuleMetaInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerModuleMetaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save Model Feature Configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <list type="bullet">
        /// <item><description>This interface is used to query all available feature templates in the system.</description></item>
        /// <item><description>The request method is GET, and no additional parameters are required.</description></item>
        /// <item><description>The returned result includes multiple feature template options, each option including a label (label) and value (value).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleMetaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleMetaInfoResponse
        /// </returns>
        public CreateCustomerModuleMetaInfoResponse CreateCustomerModuleMetaInfo(CreateCustomerModuleMetaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomerModuleMetaInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save Model Feature Configuration</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <list type="bullet">
        /// <item><description>This interface is used to query all available feature templates in the system.</description></item>
        /// <item><description>The request method is GET, and no additional parameters are required.</description></item>
        /// <item><description>The returned result includes multiple feature template options, each option including a label (label) and value (value).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleMetaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleMetaInfoResponse
        /// </returns>
        public async Task<CreateCustomerModuleMetaInfoResponse> CreateCustomerModuleMetaInfoAsync(CreateCustomerModuleMetaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomerModuleMetaInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Model Output Information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleOutputInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleOutputInfoResponse
        /// </returns>
        public CreateCustomerModuleOutputInfoResponse CreateCustomerModuleOutputInfoWithOptions(CreateCustomerModuleOutputInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalScoreFormat))
            {
                query["FinalScoreFormat"] = request.FinalScoreFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessExpression))
            {
                query["ProcessExpression"] = request.ProcessExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestFileUrl))
            {
                query["TestFileUrl"] = request.TestFileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomerModuleOutputInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerModuleOutputInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Model Output Information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleOutputInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleOutputInfoResponse
        /// </returns>
        public async Task<CreateCustomerModuleOutputInfoResponse> CreateCustomerModuleOutputInfoWithOptionsAsync(CreateCustomerModuleOutputInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FinalScoreFormat))
            {
                query["FinalScoreFormat"] = request.FinalScoreFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessExpression))
            {
                query["ProcessExpression"] = request.ProcessExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestFileUrl))
            {
                query["TestFileUrl"] = request.TestFileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomerModuleOutputInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomerModuleOutputInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Model Output Information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleOutputInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleOutputInfoResponse
        /// </returns>
        public CreateCustomerModuleOutputInfoResponse CreateCustomerModuleOutputInfo(CreateCustomerModuleOutputInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomerModuleOutputInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Model Output Information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomerModuleOutputInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomerModuleOutputInfoResponse
        /// </returns>
        public async Task<CreateCustomerModuleOutputInfoResponse> CreateCustomerModuleOutputInfoAsync(CreateCustomerModuleOutputInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomerModuleOutputInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the specified customer model based on the provided customer model ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to delete a specified customer model from the system. When calling, you must provide the <c>customerModuleId</c> parameter, which identifies the specific model to be deleted.</para>
        /// <list type="bullet">
        /// <item><description><b>Note</b>: Deletion is irreversible, please use with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModelWithOptions(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the specified customer model based on the provided customer model ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to delete a specified customer model from the system. When calling, you must provide the <c>customerModuleId</c> parameter, which identifies the specific model to be deleted.</para>
        /// <list type="bullet">
        /// <item><description><b>Note</b>: Deletion is irreversible, please use with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the specified customer model based on the provided customer model ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to delete a specified customer model from the system. When calling, you must provide the <c>customerModuleId</c> parameter, which identifies the specific model to be deleted.</para>
        /// <list type="bullet">
        /// <item><description><b>Note</b>: Deletion is irreversible, please use with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the specified customer model based on the provided customer model ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to delete a specified customer model from the system. When calling, you must provide the <c>customerModuleId</c> parameter, which identifies the specific model to be deleted.</para>
        /// <list type="bullet">
        /// <item><description><b>Note</b>: Deletion is irreversible, please use with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteModelResponse
        /// </returns>
        public async Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query basic model information based on the customer model ID</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>By providing the <c>customerModuleId</c> parameter, you can query the current status of a specified customer model. The status values may include but are not limited to &quot;EDIT&quot;, &quot;ONLINE&quot;, etc.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleBasicInfoResponse
        /// </returns>
        public DescribeCustomerModuleBasicInfoResponse DescribeCustomerModuleBasicInfoWithOptions(DescribeCustomerModuleBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomerModuleBasicInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomerModuleBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query basic model information based on the customer model ID</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>By providing the <c>customerModuleId</c> parameter, you can query the current status of a specified customer model. The status values may include but are not limited to &quot;EDIT&quot;, &quot;ONLINE&quot;, etc.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleBasicInfoResponse
        /// </returns>
        public async Task<DescribeCustomerModuleBasicInfoResponse> DescribeCustomerModuleBasicInfoWithOptionsAsync(DescribeCustomerModuleBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomerModuleBasicInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomerModuleBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query basic model information based on the customer model ID</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>By providing the <c>customerModuleId</c> parameter, you can query the current status of a specified customer model. The status values may include but are not limited to &quot;EDIT&quot;, &quot;ONLINE&quot;, etc.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleBasicInfoResponse
        /// </returns>
        public DescribeCustomerModuleBasicInfoResponse DescribeCustomerModuleBasicInfo(DescribeCustomerModuleBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomerModuleBasicInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query basic model information based on the customer model ID</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>By providing the <c>customerModuleId</c> parameter, you can query the current status of a specified customer model. The status values may include but are not limited to &quot;EDIT&quot;, &quot;ONLINE&quot;, etc.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleBasicInfoResponse
        /// </returns>
        public async Task<DescribeCustomerModuleBasicInfoResponse> DescribeCustomerModuleBasicInfoAsync(DescribeCustomerModuleBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomerModuleBasicInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型特征信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleMetaInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleMetaInfoResponse
        /// </returns>
        public DescribeCustomerModuleMetaInfoResponse DescribeCustomerModuleMetaInfoWithOptions(DescribeCustomerModuleMetaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomerModuleMetaInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomerModuleMetaInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型特征信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleMetaInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleMetaInfoResponse
        /// </returns>
        public async Task<DescribeCustomerModuleMetaInfoResponse> DescribeCustomerModuleMetaInfoWithOptionsAsync(DescribeCustomerModuleMetaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomerModuleMetaInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomerModuleMetaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型特征信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleMetaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleMetaInfoResponse
        /// </returns>
        public DescribeCustomerModuleMetaInfoResponse DescribeCustomerModuleMetaInfo(DescribeCustomerModuleMetaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomerModuleMetaInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型特征信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleMetaInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleMetaInfoResponse
        /// </returns>
        public async Task<DescribeCustomerModuleMetaInfoResponse> DescribeCustomerModuleMetaInfoAsync(DescribeCustomerModuleMetaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomerModuleMetaInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型出参信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleOutputInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleOutputInfoResponse
        /// </returns>
        public DescribeCustomerModuleOutputInfoResponse DescribeCustomerModuleOutputInfoWithOptions(DescribeCustomerModuleOutputInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomerModuleOutputInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomerModuleOutputInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型出参信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleOutputInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleOutputInfoResponse
        /// </returns>
        public async Task<DescribeCustomerModuleOutputInfoResponse> DescribeCustomerModuleOutputInfoWithOptionsAsync(DescribeCustomerModuleOutputInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomerModuleOutputInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomerModuleOutputInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型出参信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleOutputInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleOutputInfoResponse
        /// </returns>
        public DescribeCustomerModuleOutputInfoResponse DescribeCustomerModuleOutputInfo(DescribeCustomerModuleOutputInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomerModuleOutputInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型出参信息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCustomerModuleOutputInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCustomerModuleOutputInfoResponse
        /// </returns>
        public async Task<DescribeCustomerModuleOutputInfoResponse> DescribeCustomerModuleOutputInfoAsync(DescribeCustomerModuleOutputInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomerModuleOutputInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据特征模板返回特征模板具体特征选项</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFeatureOptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFeatureOptionResponse
        /// </returns>
        public DescribeFeatureOptionResponse DescribeFeatureOptionWithOptions(DescribeFeatureOptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureTemplate))
            {
                query["FeatureTemplate"] = request.FeatureTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFeatureOption",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFeatureOptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据特征模板返回特征模板具体特征选项</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFeatureOptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFeatureOptionResponse
        /// </returns>
        public async Task<DescribeFeatureOptionResponse> DescribeFeatureOptionWithOptionsAsync(DescribeFeatureOptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureTemplate))
            {
                query["FeatureTemplate"] = request.FeatureTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFeatureOption",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFeatureOptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据特征模板返回特征模板具体特征选项</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFeatureOptionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFeatureOptionResponse
        /// </returns>
        public DescribeFeatureOptionResponse DescribeFeatureOption(DescribeFeatureOptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFeatureOptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据特征模板返回特征模板具体特征选项</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFeatureOptionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFeatureOptionResponse
        /// </returns>
        public async Task<DescribeFeatureOptionResponse> DescribeFeatureOptionAsync(DescribeFeatureOptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFeatureOptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可用的特征模板列表，用于模型配置。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFeatureTemplateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFeatureTemplateListResponse
        /// </returns>
        public DescribeFeatureTemplateListResponse DescribeFeatureTemplateListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFeatureTemplateList",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFeatureTemplateListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可用的特征模板列表，用于模型配置。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeFeatureTemplateListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFeatureTemplateListResponse
        /// </returns>
        public async Task<DescribeFeatureTemplateListResponse> DescribeFeatureTemplateListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFeatureTemplateList",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFeatureTemplateListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可用的特征模板列表，用于模型配置。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// DescribeFeatureTemplateListResponse
        /// </returns>
        public DescribeFeatureTemplateListResponse DescribeFeatureTemplateList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFeatureTemplateListWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取可用的特征模板列表，用于模型配置。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// DescribeFeatureTemplateListResponse
        /// </returns>
        public async Task<DescribeFeatureTemplateListResponse> DescribeFeatureTemplateListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFeatureTemplateListWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染模型的特征配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModelFeatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelFeatureResponse
        /// </returns>
        public DescribeModelFeatureResponse DescribeModelFeatureWithOptions(DescribeModelFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureTemplate))
            {
                query["FeatureTemplate"] = request.FeatureTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModelFeature",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModelFeatureResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染模型的特征配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModelFeatureRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelFeatureResponse
        /// </returns>
        public async Task<DescribeModelFeatureResponse> DescribeModelFeatureWithOptionsAsync(DescribeModelFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureTemplate))
            {
                query["FeatureTemplate"] = request.FeatureTemplate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModelFeature",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModelFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染模型的特征配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModelFeatureRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelFeatureResponse
        /// </returns>
        public DescribeModelFeatureResponse DescribeModelFeature(DescribeModelFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModelFeatureWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>渲染模型的特征配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModelFeatureRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelFeatureResponse
        /// </returns>
        public async Task<DescribeModelFeatureResponse> DescribeModelFeatureAsync(DescribeModelFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModelFeatureWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传oss鉴权数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeModelOssTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelOssTokenResponse
        /// </returns>
        public DescribeModelOssTokenResponse DescribeModelOssTokenWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModelOssToken",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModelOssTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传oss鉴权数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeModelOssTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelOssTokenResponse
        /// </returns>
        public async Task<DescribeModelOssTokenResponse> DescribeModelOssTokenWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModelOssToken",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModelOssTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传oss鉴权数据</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeModelOssTokenResponse
        /// </returns>
        public DescribeModelOssTokenResponse DescribeModelOssToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModelOssTokenWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取上传oss鉴权数据</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeModelOssTokenResponse
        /// </returns>
        public async Task<DescribeModelOssTokenResponse> DescribeModelOssTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModelOssTokenWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询指定模型对应服务是否存在</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该接口用于通过提供的<c>customerModuleId</c>来检查特定的模型服务是否已经存在。如果存在，则返回<c>true</c>；反之则返回<c>false</c>。</para>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description><c>customerModuleId</c>是必须提供的参数，且为字符串类型。</description></item>
        /// <item><description>此API主要用于前端页面展示或逻辑判断时使用，以确认用户所选模型是否有对应的服务被创建。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModuleServiceExistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModuleServiceExistResponse
        /// </returns>
        public DescribeModuleServiceExistResponse DescribeModuleServiceExistWithOptions(DescribeModuleServiceExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModuleServiceExist",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModuleServiceExistResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询指定模型对应服务是否存在</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该接口用于通过提供的<c>customerModuleId</c>来检查特定的模型服务是否已经存在。如果存在，则返回<c>true</c>；反之则返回<c>false</c>。</para>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description><c>customerModuleId</c>是必须提供的参数，且为字符串类型。</description></item>
        /// <item><description>此API主要用于前端页面展示或逻辑判断时使用，以确认用户所选模型是否有对应的服务被创建。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModuleServiceExistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModuleServiceExistResponse
        /// </returns>
        public async Task<DescribeModuleServiceExistResponse> DescribeModuleServiceExistWithOptionsAsync(DescribeModuleServiceExistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModuleServiceExist",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModuleServiceExistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询指定模型对应服务是否存在</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该接口用于通过提供的<c>customerModuleId</c>来检查特定的模型服务是否已经存在。如果存在，则返回<c>true</c>；反之则返回<c>false</c>。</para>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description><c>customerModuleId</c>是必须提供的参数，且为字符串类型。</description></item>
        /// <item><description>此API主要用于前端页面展示或逻辑判断时使用，以确认用户所选模型是否有对应的服务被创建。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModuleServiceExistRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeModuleServiceExistResponse
        /// </returns>
        public DescribeModuleServiceExistResponse DescribeModuleServiceExist(DescribeModuleServiceExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModuleServiceExistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询指定模型对应服务是否存在</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该接口用于通过提供的<c>customerModuleId</c>来检查特定的模型服务是否已经存在。如果存在，则返回<c>true</c>；反之则返回<c>false</c>。</para>
        /// <h3>注意事项</h3>
        /// <list type="bullet">
        /// <item><description><c>customerModuleId</c>是必须提供的参数，且为字符串类型。</description></item>
        /// <item><description>此API主要用于前端页面展示或逻辑判断时使用，以确认用户所选模型是否有对应的服务被创建。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModuleServiceExistRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeModuleServiceExistResponse
        /// </returns>
        public async Task<DescribeModuleServiceExistResponse> DescribeModuleServiceExistAsync(DescribeModuleServiceExistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModuleServiceExistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型当前状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModuleStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModuleStatusResponse
        /// </returns>
        public DescribeModuleStatusResponse DescribeModuleStatusWithOptions(DescribeModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModuleStatus",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModuleStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型当前状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModuleStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModuleStatusResponse
        /// </returns>
        public async Task<DescribeModuleStatusResponse> DescribeModuleStatusWithOptionsAsync(DescribeModuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeModuleStatus",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModuleStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型当前状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModuleStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeModuleStatusResponse
        /// </returns>
        public DescribeModuleStatusResponse DescribeModuleStatus(DescribeModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModuleStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据客户模型ID查询模型当前状态</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>通过提供<c>customerModuleId</c>参数，可以查询指定客户模型的当前状态。状态值可能包括但不限于&quot;EDIT&quot;、&quot;ONLINE&quot;等。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModuleStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeModuleStatusResponse
        /// </returns>
        public async Task<DescribeModuleStatusResponse> DescribeModuleStatusAsync(DescribeModuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModuleStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型托管订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSafRmmpOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSafRmmpOrderResponse
        /// </returns>
        public DescribeSafRmmpOrderResponse DescribeSafRmmpOrderWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSafRmmpOrder",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSafRmmpOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型托管订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSafRmmpOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSafRmmpOrderResponse
        /// </returns>
        public async Task<DescribeSafRmmpOrderResponse> DescribeSafRmmpOrderWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSafRmmpOrder",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSafRmmpOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型托管订单</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeSafRmmpOrderResponse
        /// </returns>
        public DescribeSafRmmpOrderResponse DescribeSafRmmpOrder()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSafRmmpOrderWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询模型托管订单</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeSafRmmpOrderResponse
        /// </returns>
        public async Task<DescribeSafRmmpOrderResponse> DescribeSafRmmpOrderAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSafRmmpOrderWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询场景和服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceAndSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceAndSceneResponse
        /// </returns>
        public DescribeServiceAndSceneResponse DescribeServiceAndSceneWithOptions(DescribeServiceAndSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceAndScene",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceAndSceneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询场景和服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceAndSceneRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceAndSceneResponse
        /// </returns>
        public async Task<DescribeServiceAndSceneResponse> DescribeServiceAndSceneWithOptionsAsync(DescribeServiceAndSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceAndScene",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceAndSceneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询场景和服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceAndSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceAndSceneResponse
        /// </returns>
        public DescribeServiceAndSceneResponse DescribeServiceAndScene(DescribeServiceAndSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceAndSceneWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询场景和服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceAndSceneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceAndSceneResponse
        /// </returns>
        public async Task<DescribeServiceAndSceneResponse> DescribeServiceAndSceneAsync(DescribeServiceAndSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceAndSceneWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定用户下的所有模型信息，支持分页查询</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于查询特定用户下的所有模型信息，并支持通过分页参数进行分页查询。可以通过 <c>name</c> 参数进行模糊搜索。</para>
        /// <list type="bullet">
        /// <item><description><c>regId</c>: 地域标识，必填。</description></item>
        /// <item><description><c>pageSize</c>: 每页显示的条目数，必填。</description></item>
        /// <item><description><c>currentPage</c>: 当前页码，从1开始计数，必填。</description></item>
        /// <item><description><c>userId</c>: 用户ID，必填。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserModelListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserModelListResponse
        /// </returns>
        public DescribeUserModelListResponse DescribeUserModelListWithOptions(DescribeUserModelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserModelList",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserModelListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定用户下的所有模型信息，支持分页查询</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于查询特定用户下的所有模型信息，并支持通过分页参数进行分页查询。可以通过 <c>name</c> 参数进行模糊搜索。</para>
        /// <list type="bullet">
        /// <item><description><c>regId</c>: 地域标识，必填。</description></item>
        /// <item><description><c>pageSize</c>: 每页显示的条目数，必填。</description></item>
        /// <item><description><c>currentPage</c>: 当前页码，从1开始计数，必填。</description></item>
        /// <item><description><c>userId</c>: 用户ID，必填。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserModelListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserModelListResponse
        /// </returns>
        public async Task<DescribeUserModelListResponse> DescribeUserModelListWithOptionsAsync(DescribeUserModelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthType))
            {
                query["AuthType"] = request.AuthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserModelList",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserModelListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定用户下的所有模型信息，支持分页查询</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于查询特定用户下的所有模型信息，并支持通过分页参数进行分页查询。可以通过 <c>name</c> 参数进行模糊搜索。</para>
        /// <list type="bullet">
        /// <item><description><c>regId</c>: 地域标识，必填。</description></item>
        /// <item><description><c>pageSize</c>: 每页显示的条目数，必填。</description></item>
        /// <item><description><c>currentPage</c>: 当前页码，从1开始计数，必填。</description></item>
        /// <item><description><c>userId</c>: 用户ID，必填。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserModelListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserModelListResponse
        /// </returns>
        public DescribeUserModelListResponse DescribeUserModelList(DescribeUserModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserModelListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取指定用户下的所有模型信息，支持分页查询</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>该 API 用于查询特定用户下的所有模型信息，并支持通过分页参数进行分页查询。可以通过 <c>name</c> 参数进行模糊搜索。</para>
        /// <list type="bullet">
        /// <item><description><c>regId</c>: 地域标识，必填。</description></item>
        /// <item><description><c>pageSize</c>: 每页显示的条目数，必填。</description></item>
        /// <item><description><c>currentPage</c>: 当前页码，从1开始计数，必填。</description></item>
        /// <item><description><c>userId</c>: 用户ID，必填。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUserModelListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUserModelListResponse
        /// </returns>
        public async Task<DescribeUserModelListResponse> DescribeUserModelListAsync(DescribeUserModelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserModelListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迭代模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DuplicateModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DuplicateModelResponse
        /// </returns>
        public DuplicateModelResponse DuplicateModelWithOptions(DuplicateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DuplicateModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DuplicateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迭代模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DuplicateModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DuplicateModelResponse
        /// </returns>
        public async Task<DuplicateModelResponse> DuplicateModelWithOptionsAsync(DuplicateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DuplicateModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DuplicateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迭代模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DuplicateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DuplicateModelResponse
        /// </returns>
        public DuplicateModelResponse DuplicateModel(DuplicateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DuplicateModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迭代模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DuplicateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// DuplicateModelResponse
        /// </returns>
        public async Task<DuplicateModelResponse> DuplicateModelAsync(DuplicateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DuplicateModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditModelResponse
        /// </returns>
        public EditModelResponse EditModelWithOptions(EditModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EditModelResponse
        /// </returns>
        public async Task<EditModelResponse> EditModelWithOptionsAsync(EditModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditModelRequest
        /// </param>
        /// 
        /// <returns>
        /// EditModelResponse
        /// </returns>
        public EditModelResponse EditModel(EditModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>编辑模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EditModelRequest
        /// </param>
        /// 
        /// <returns>
        /// EditModelResponse
        /// </returns>
        public async Task<EditModelResponse> EditModelAsync(EditModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迭代模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// IterateModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IterateModelResponse
        /// </returns>
        public IterateModelResponse IterateModelWithOptions(IterateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IterateModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IterateModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迭代模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// IterateModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IterateModelResponse
        /// </returns>
        public async Task<IterateModelResponse> IterateModelWithOptionsAsync(IterateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IterateModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IterateModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迭代模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// IterateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// IterateModelResponse
        /// </returns>
        public IterateModelResponse IterateModel(IterateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IterateModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>迭代模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// IterateModelRequest
        /// </param>
        /// 
        /// <returns>
        /// IterateModelResponse
        /// </returns>
        public async Task<IterateModelResponse> IterateModelAsync(IterateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IterateModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineModelResponse
        /// </returns>
        public OfflineModelResponse OfflineModelWithOptions(OfflineModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OfflineModelResponse
        /// </returns>
        public async Task<OfflineModelResponse> OfflineModelWithOptionsAsync(OfflineModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OfflineModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OfflineModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineModelRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineModelResponse
        /// </returns>
        public OfflineModelResponse OfflineModel(OfflineModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OfflineModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>下线模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OfflineModelRequest
        /// </param>
        /// 
        /// <returns>
        /// OfflineModelResponse
        /// </returns>
        public async Task<OfflineModelResponse> OfflineModelAsync(OfflineModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OfflineModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// OnlineModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineModelResponse
        /// </returns>
        public OnlineModelResponse OnlineModelWithOptions(OnlineModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// OnlineModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OnlineModelResponse
        /// </returns>
        public async Task<OnlineModelResponse> OnlineModelWithOptionsAsync(OnlineModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnlineModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnlineModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// OnlineModelRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineModelResponse
        /// </returns>
        public OnlineModelResponse OnlineModel(OnlineModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnlineModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上线模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <para>本API用于从系统中删除指定的客户模型。调用时必须提供<c>customerModuleId</c>参数，该参数标识了要删除的具体模型。</para>
        /// <list type="bullet">
        /// <item><description><b>注意</b>：删除操作不可逆，请谨慎使用。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// OnlineModelRequest
        /// </param>
        /// 
        /// <returns>
        /// OnlineModelResponse
        /// </returns>
        public async Task<OnlineModelResponse> OnlineModelAsync(OnlineModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnlineModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析表达式参数</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ParseExpressionParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ParseExpressionParametersResponse
        /// </returns>
        public ParseExpressionParametersResponse ParseExpressionParametersWithOptions(ParseExpressionParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ParseExpressionParameters",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ParseExpressionParametersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析表达式参数</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ParseExpressionParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ParseExpressionParametersResponse
        /// </returns>
        public async Task<ParseExpressionParametersResponse> ParseExpressionParametersWithOptionsAsync(ParseExpressionParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ParseExpressionParameters",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ParseExpressionParametersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析表达式参数</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ParseExpressionParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// ParseExpressionParametersResponse
        /// </returns>
        public ParseExpressionParametersResponse ParseExpressionParameters(ParseExpressionParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ParseExpressionParametersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解析表达式参数</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ParseExpressionParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// ParseExpressionParametersResponse
        /// </returns>
        public async Task<ParseExpressionParametersResponse> ParseExpressionParametersAsync(ParseExpressionParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ParseExpressionParametersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrepublishModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrepublishModelResponse
        /// </returns>
        public PrepublishModelResponse PrepublishModelWithOptions(PrepublishModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrepublishModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrepublishModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrepublishModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PrepublishModelResponse
        /// </returns>
        public async Task<PrepublishModelResponse> PrepublishModelWithOptionsAsync(PrepublishModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PrepublishModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PrepublishModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrepublishModelRequest
        /// </param>
        /// 
        /// <returns>
        /// PrepublishModelResponse
        /// </returns>
        public PrepublishModelResponse PrepublishModel(PrepublishModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PrepublishModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PrepublishModelRequest
        /// </param>
        /// 
        /// <returns>
        /// PrepublishModelResponse
        /// </returns>
        public async Task<PrepublishModelResponse> PrepublishModelAsync(PrepublishModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PrepublishModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Roll back the specified customer model based on the provided customer model ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to delete a specified customer model from the system. When calling, you must provide the <c>customerModuleId</c> parameter, which identifies the specific model to be deleted.</para>
        /// <list type="bullet">
        /// <item><description><b>Note</b>: The deletion operation is irreversible, please use with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RollbackModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackModelResponse
        /// </returns>
        public RollbackModelResponse RollbackModelWithOptions(RollbackModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Roll back the specified customer model based on the provided customer model ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to delete a specified customer model from the system. When calling, you must provide the <c>customerModuleId</c> parameter, which identifies the specific model to be deleted.</para>
        /// <list type="bullet">
        /// <item><description><b>Note</b>: The deletion operation is irreversible, please use with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RollbackModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackModelResponse
        /// </returns>
        public async Task<RollbackModelResponse> RollbackModelWithOptionsAsync(RollbackModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Roll back the specified customer model based on the provided customer model ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to delete a specified customer model from the system. When calling, you must provide the <c>customerModuleId</c> parameter, which identifies the specific model to be deleted.</para>
        /// <list type="bullet">
        /// <item><description><b>Note</b>: The deletion operation is irreversible, please use with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RollbackModelRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackModelResponse
        /// </returns>
        public RollbackModelResponse RollbackModel(RollbackModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Roll back the specified customer model based on the provided customer model ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request Description</h2>
        /// <para>This API is used to delete a specified customer model from the system. When calling, you must provide the <c>customerModuleId</c> parameter, which identifies the specific model to be deleted.</para>
        /// <list type="bullet">
        /// <item><description><b>Note</b>: The deletion operation is irreversible, please use with caution.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RollbackModelRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackModelResponse
        /// </returns>
        public async Task<RollbackModelResponse> RollbackModelAsync(RollbackModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布测试模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestModelResponse
        /// </returns>
        public TestModelResponse TestModelWithOptions(TestModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布测试模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestModelResponse
        /// </returns>
        public async Task<TestModelResponse> TestModelWithOptionsAsync(TestModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布测试模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestModelRequest
        /// </param>
        /// 
        /// <returns>
        /// TestModelResponse
        /// </returns>
        public TestModelResponse TestModel(TestModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布测试模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestModelRequest
        /// </param>
        /// 
        /// <returns>
        /// TestModelResponse
        /// </returns>
        public async Task<TestModelResponse> TestModelAsync(TestModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布测试模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestPreModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestPreModelResponse
        /// </returns>
        public TestPreModelResponse TestPreModelWithOptions(TestPreModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestPreModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestPreModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布测试模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestPreModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestPreModelResponse
        /// </returns>
        public async Task<TestPreModelResponse> TestPreModelWithOptionsAsync(TestPreModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestPreModel",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestPreModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布测试模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestPreModelRequest
        /// </param>
        /// 
        /// <returns>
        /// TestPreModelResponse
        /// </returns>
        public TestPreModelResponse TestPreModel(TestPreModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestPreModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预发布测试模型</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestPreModelRequest
        /// </param>
        /// 
        /// <returns>
        /// TestPreModelResponse
        /// </returns>
        public async Task<TestPreModelResponse> TestPreModelAsync(TestPreModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestPreModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试表达式</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestProcessExpressionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestProcessExpressionResponse
        /// </returns>
        public TestProcessExpressionResponse TestProcessExpressionWithOptions(TestProcessExpressionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestProcessExpression",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestProcessExpressionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试表达式</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestProcessExpressionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestProcessExpressionResponse
        /// </returns>
        public async Task<TestProcessExpressionResponse> TestProcessExpressionWithOptionsAsync(TestProcessExpressionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                query["Params"] = request.Params;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestProcessExpression",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestProcessExpressionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试表达式</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestProcessExpressionRequest
        /// </param>
        /// 
        /// <returns>
        /// TestProcessExpressionResponse
        /// </returns>
        public TestProcessExpressionResponse TestProcessExpression(TestProcessExpressionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestProcessExpressionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试表达式</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于查询系统中所有可用的特征模板。</description></item>
        /// <item><description>请求方式为 GET，无需提供额外参数。</description></item>
        /// <item><description>返回结果包含多个特征模板选项，每个选项包括标签（label）和值（value）。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestProcessExpressionRequest
        /// </param>
        /// 
        /// <returns>
        /// TestProcessExpressionResponse
        /// </returns>
        public async Task<TestProcessExpressionResponse> TestProcessExpressionAsync(TestProcessExpressionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestProcessExpressionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update basic model information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModuleBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModuleBasicInfoResponse
        /// </returns>
        public UpdateModuleBasicInfoResponse UpdateModuleBasicInfoWithOptions(UpdateModuleBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleName))
            {
                query["CustomerModuleName"] = request.CustomerModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                query["ModuleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorePath))
            {
                query["StorePath"] = request.StorePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModuleBasicInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModuleBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update basic model information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModuleBasicInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModuleBasicInfoResponse
        /// </returns>
        public async Task<UpdateModuleBasicInfoResponse> UpdateModuleBasicInfoWithOptionsAsync(UpdateModuleBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleName))
            {
                query["CustomerModuleName"] = request.CustomerModuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                query["ModuleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorePath))
            {
                query["StorePath"] = request.StorePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModuleBasicInfo",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModuleBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update basic model information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModuleBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModuleBasicInfoResponse
        /// </returns>
        public UpdateModuleBasicInfoResponse UpdateModuleBasicInfo(UpdateModuleBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateModuleBasicInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update basic model information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModuleBasicInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModuleBasicInfoResponse
        /// </returns>
        public async Task<UpdateModuleBasicInfoResponse> UpdateModuleBasicInfoAsync(UpdateModuleBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateModuleBasicInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate model file</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateModelFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateModelFileResponse
        /// </returns>
        public ValidateModelFileResponse ValidateModelFileWithOptions(ValidateModelFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateModelFile",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateModelFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate model file</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateModelFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateModelFileResponse
        /// </returns>
        public async Task<ValidateModelFileResponse> ValidateModelFileWithOptionsAsync(ValidateModelFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateModelFile",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateModelFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate model file</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateModelFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateModelFileResponse
        /// </returns>
        public ValidateModelFileResponse ValidateModelFile(ValidateModelFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateModelFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate model file</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateModelFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateModelFileResponse
        /// </returns>
        public async Task<ValidateModelFileResponse> ValidateModelFileAsync(ValidateModelFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateModelFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate Test File</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateTestFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateTestFileResponse
        /// </returns>
        public ValidateTestFileResponse ValidateTestFileWithOptions(ValidateTestFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateTestFile",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateTestFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate Test File</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateTestFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ValidateTestFileResponse
        /// </returns>
        public async Task<ValidateTestFileResponse> ValidateTestFileWithOptionsAsync(ValidateTestFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerModuleId))
            {
                query["CustomerModuleId"] = request.CustomerModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                query["FilePath"] = request.FilePath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateTestFile",
                Version = "2025-05-21",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateTestFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate Test File</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateTestFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateTestFileResponse
        /// </returns>
        public ValidateTestFileResponse ValidateTestFile(ValidateTestFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateTestFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validate Test File</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ValidateTestFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ValidateTestFileResponse
        /// </returns>
        public async Task<ValidateTestFileResponse> ValidateTestFileAsync(ValidateTestFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateTestFileWithOptionsAsync(request, runtime);
        }

    }
}
