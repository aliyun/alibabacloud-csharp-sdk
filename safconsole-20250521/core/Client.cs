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

    }
}
