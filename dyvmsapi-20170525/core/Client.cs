// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dyvmsapi20170525.Models;

namespace AlibabaCloud.SDK.Dyvmsapi20170525
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dyvmsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Binds multiple real numbers to a service instance at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddVirtualNumberRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddVirtualNumberRelationResponse
        /// </returns>
        public AddVirtualNumberRelationResponse AddVirtualNumberRelationWithOptions(AddVirtualNumberRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpNameList))
            {
                query["CorpNameList"] = request.CorpNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberList))
            {
                query["NumberList"] = request.NumberList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNum))
            {
                query["PhoneNum"] = request.PhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                query["RouteType"] = request.RouteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVirtualNumberRelation",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVirtualNumberRelationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds multiple real numbers to a service instance at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddVirtualNumberRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddVirtualNumberRelationResponse
        /// </returns>
        public async Task<AddVirtualNumberRelationResponse> AddVirtualNumberRelationWithOptionsAsync(AddVirtualNumberRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpNameList))
            {
                query["CorpNameList"] = request.CorpNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberList))
            {
                query["NumberList"] = request.NumberList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNum))
            {
                query["PhoneNum"] = request.PhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                query["RouteType"] = request.RouteType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddVirtualNumberRelation",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddVirtualNumberRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds multiple real numbers to a service instance at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddVirtualNumberRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// AddVirtualNumberRelationResponse
        /// </returns>
        public AddVirtualNumberRelationResponse AddVirtualNumberRelation(AddVirtualNumberRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVirtualNumberRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds multiple real numbers to a service instance at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddVirtualNumberRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// AddVirtualNumberRelationResponse
        /// </returns>
        public async Task<AddVirtualNumberRelationResponse> AddVirtualNumberRelationAsync(AddVirtualNumberRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVirtualNumberRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates outbound robocall tasks in a batch. You can set up to 100 numbers in a task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  In an intelligent speech interaction task, you can use the robot communication scripts preset in the Voice Messaging Service console, or invoke the callback function to return the response mode configured by the business party in each call.</para>
        /// <list type="bullet">
        /// <item><description>The BatchRobotSmartCall operation is used to initiate an outbound robocall task by using the robot communication scripts preset in the Voice Messaging Service console.</description></item>
        /// </list>
        /// <h2>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>You have passed the real-name verification for an enterprise user and passed the enterprise qualification review.</description></item>
        /// <item><description>You have purchased numbers in the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/number/normal">Voice Messaging Service console</a>.</description></item>
        /// <item><description>You have added communication scripts on the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/smart-call/saas/robot/list">Communication script management</a> page, and the communication scripts have been approved.<remarks>
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://www.aliyun.com/price/product#/vms/detail">billing</a> of Voice Messaging Service (VMS).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchRobotSmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRobotSmartCallResponse
        /// </returns>
        public BatchRobotSmartCallResponse BatchRobotSmartCallWithOptions(BatchRobotSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                query["CorpName"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogId))
            {
                query["DialogId"] = request.DialogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSelfLine))
            {
                query["IsSelfLine"] = request.IsSelfLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleCall))
            {
                query["ScheduleCall"] = request.ScheduleCall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParam))
            {
                query["TtsParam"] = request.TtsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParamHead))
            {
                query["TtsParamHead"] = request.TtsParamHead;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRobotSmartCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRobotSmartCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates outbound robocall tasks in a batch. You can set up to 100 numbers in a task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  In an intelligent speech interaction task, you can use the robot communication scripts preset in the Voice Messaging Service console, or invoke the callback function to return the response mode configured by the business party in each call.</para>
        /// <list type="bullet">
        /// <item><description>The BatchRobotSmartCall operation is used to initiate an outbound robocall task by using the robot communication scripts preset in the Voice Messaging Service console.</description></item>
        /// </list>
        /// <h2>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>You have passed the real-name verification for an enterprise user and passed the enterprise qualification review.</description></item>
        /// <item><description>You have purchased numbers in the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/number/normal">Voice Messaging Service console</a>.</description></item>
        /// <item><description>You have added communication scripts on the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/smart-call/saas/robot/list">Communication script management</a> page, and the communication scripts have been approved.<remarks>
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://www.aliyun.com/price/product#/vms/detail">billing</a> of Voice Messaging Service (VMS).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchRobotSmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRobotSmartCallResponse
        /// </returns>
        public async Task<BatchRobotSmartCallResponse> BatchRobotSmartCallWithOptionsAsync(BatchRobotSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                query["CorpName"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogId))
            {
                query["DialogId"] = request.DialogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSelfLine))
            {
                query["IsSelfLine"] = request.IsSelfLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleCall))
            {
                query["ScheduleCall"] = request.ScheduleCall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParam))
            {
                query["TtsParam"] = request.TtsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParamHead))
            {
                query["TtsParamHead"] = request.TtsParamHead;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRobotSmartCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRobotSmartCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates outbound robocall tasks in a batch. You can set up to 100 numbers in a task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  In an intelligent speech interaction task, you can use the robot communication scripts preset in the Voice Messaging Service console, or invoke the callback function to return the response mode configured by the business party in each call.</para>
        /// <list type="bullet">
        /// <item><description>The BatchRobotSmartCall operation is used to initiate an outbound robocall task by using the robot communication scripts preset in the Voice Messaging Service console.</description></item>
        /// </list>
        /// <h2>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>You have passed the real-name verification for an enterprise user and passed the enterprise qualification review.</description></item>
        /// <item><description>You have purchased numbers in the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/number/normal">Voice Messaging Service console</a>.</description></item>
        /// <item><description>You have added communication scripts on the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/smart-call/saas/robot/list">Communication script management</a> page, and the communication scripts have been approved.<remarks>
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://www.aliyun.com/price/product#/vms/detail">billing</a> of Voice Messaging Service (VMS).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchRobotSmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRobotSmartCallResponse
        /// </returns>
        public BatchRobotSmartCallResponse BatchRobotSmartCall(BatchRobotSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchRobotSmartCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates outbound robocall tasks in a batch. You can set up to 100 numbers in a task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  In an intelligent speech interaction task, you can use the robot communication scripts preset in the Voice Messaging Service console, or invoke the callback function to return the response mode configured by the business party in each call.</para>
        /// <list type="bullet">
        /// <item><description>The BatchRobotSmartCall operation is used to initiate an outbound robocall task by using the robot communication scripts preset in the Voice Messaging Service console.</description></item>
        /// </list>
        /// <h2>Prerequisites</h2>
        /// <list type="bullet">
        /// <item><description>You have passed the real-name verification for an enterprise user and passed the enterprise qualification review.</description></item>
        /// <item><description>You have purchased numbers in the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/number/normal">Voice Messaging Service console</a>.</description></item>
        /// <item><description>You have added communication scripts on the <a href="https://dyvms.console.aliyun.com/dyvms.htm#/smart-call/saas/robot/list">Communication script management</a> page, and the communication scripts have been approved.<remarks>
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://www.aliyun.com/price/product#/vms/detail">billing</a> of Voice Messaging Service (VMS).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchRobotSmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRobotSmartCallResponse
        /// </returns>
        public async Task<BatchRobotSmartCallResponse> BatchRobotSmartCallAsync(BatchRobotSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchRobotSmartCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the two-way call that is initiated by calling the ClickToDial operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelCallResponse
        /// </returns>
        public CancelCallResponse CancelCallWithOptions(CancelCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the two-way call that is initiated by calling the ClickToDial operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelCallResponse
        /// </returns>
        public async Task<CancelCallResponse> CancelCallWithOptionsAsync(CancelCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the two-way call that is initiated by calling the ClickToDial operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCallRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelCallResponse
        /// </returns>
        public CancelCallResponse CancelCall(CancelCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the two-way call that is initiated by calling the ClickToDial operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCallRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelCallResponse
        /// </returns>
        public async Task<CancelCallResponse> CancelCallAsync(CancelCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a robocall task that has not been started.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelOrderRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderRobotTaskResponse
        /// </returns>
        public CancelOrderRobotTaskResponse CancelOrderRobotTaskWithOptions(CancelOrderRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrderRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderRobotTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a robocall task that has not been started.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelOrderRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderRobotTaskResponse
        /// </returns>
        public async Task<CancelOrderRobotTaskResponse> CancelOrderRobotTaskWithOptionsAsync(CancelOrderRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOrderRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOrderRobotTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a robocall task that has not been started.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelOrderRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderRobotTaskResponse
        /// </returns>
        public CancelOrderRobotTaskResponse CancelOrderRobotTask(CancelOrderRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOrderRobotTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a robocall task that has not been started.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelOrderRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelOrderRobotTaskResponse
        /// </returns>
        public async Task<CancelOrderRobotTaskResponse> CancelOrderRobotTaskAsync(CancelOrderRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOrderRobotTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only a task in progress can be terminated by calling the CancelRobotTask operation, and the task cannot be resumed after it is terminated.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRobotTaskResponse
        /// </returns>
        public CancelRobotTaskResponse CancelRobotTaskWithOptions(CancelRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRobotTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only a task in progress can be terminated by calling the CancelRobotTask operation, and the task cannot be resumed after it is terminated.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRobotTaskResponse
        /// </returns>
        public async Task<CancelRobotTaskResponse> CancelRobotTaskWithOptionsAsync(CancelRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRobotTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only a task in progress can be terminated by calling the CancelRobotTask operation, and the task cannot be resumed after it is terminated.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRobotTaskResponse
        /// </returns>
        public CancelRobotTaskResponse CancelRobotTask(CancelRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRobotTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only a task in progress can be terminated by calling the CancelRobotTask operation, and the task cannot be resumed after it is terminated.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRobotTaskResponse
        /// </returns>
        public async Task<CancelRobotTaskResponse> CancelRobotTaskAsync(CancelRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRobotTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ChangeMediaType</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMediaTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMediaTypeResponse
        /// </returns>
        public ChangeMediaTypeResponse ChangeMediaTypeWithOptions(ChangeMediaTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNum))
            {
                query["CalledNum"] = request.CalledNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMediaType",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMediaTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ChangeMediaType</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMediaTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMediaTypeResponse
        /// </returns>
        public async Task<ChangeMediaTypeResponse> ChangeMediaTypeWithOptionsAsync(ChangeMediaTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNum))
            {
                query["CalledNum"] = request.CalledNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMediaType",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMediaTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ChangeMediaType</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMediaTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMediaTypeResponse
        /// </returns>
        public ChangeMediaTypeResponse ChangeMediaType(ChangeMediaTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeMediaTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ChangeMediaType</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMediaTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMediaTypeResponse
        /// </returns>
        public async Task<ChangeMediaTypeResponse> ChangeMediaTypeAsync(ChangeMediaTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeMediaTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席上线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentLoginRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentLoginResponse
        /// </returns>
        public CloudAgentLoginResponse CloudAgentLoginWithOptions(CloudAgentLoginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindTel))
            {
                query["BindTel"] = request.BindTel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindType))
            {
                query["BindType"] = request.BindType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginStatus))
            {
                query["LoginStatus"] = request.LoginStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseDescription))
            {
                query["PauseDescription"] = request.PauseDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudAgentLogin",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudAgentLoginResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席上线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentLoginRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentLoginResponse
        /// </returns>
        public async Task<CloudAgentLoginResponse> CloudAgentLoginWithOptionsAsync(CloudAgentLoginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindTel))
            {
                query["BindTel"] = request.BindTel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindType))
            {
                query["BindType"] = request.BindType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginStatus))
            {
                query["LoginStatus"] = request.LoginStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseDescription))
            {
                query["PauseDescription"] = request.PauseDescription;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudAgentLogin",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudAgentLoginResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席上线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentLoginRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentLoginResponse
        /// </returns>
        public CloudAgentLoginResponse CloudAgentLogin(CloudAgentLoginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudAgentLoginWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席上线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentLoginRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentLoginResponse
        /// </returns>
        public async Task<CloudAgentLoginResponse> CloudAgentLoginAsync(CloudAgentLoginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudAgentLoginWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentLogoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentLogoutResponse
        /// </returns>
        public CloudAgentLogoutResponse CloudAgentLogoutWithOptions(CloudAgentLogoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreOffline))
            {
                query["IgnoreOffline"] = request.IgnoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsKickout))
            {
                query["IsKickout"] = request.IsKickout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveBinding))
            {
                query["RemoveBinding"] = request.RemoveBinding;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudAgentLogout",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudAgentLogoutResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentLogoutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentLogoutResponse
        /// </returns>
        public async Task<CloudAgentLogoutResponse> CloudAgentLogoutWithOptionsAsync(CloudAgentLogoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IgnoreOffline))
            {
                query["IgnoreOffline"] = request.IgnoreOffline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsKickout))
            {
                query["IsKickout"] = request.IsKickout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveBinding))
            {
                query["RemoveBinding"] = request.RemoveBinding;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudAgentLogout",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudAgentLogoutResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentLogoutRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentLogoutResponse
        /// </returns>
        public CloudAgentLogoutResponse CloudAgentLogout(CloudAgentLogoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudAgentLogoutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席下线</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentLogoutRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentLogoutResponse
        /// </returns>
        public async Task<CloudAgentLogoutResponse> CloudAgentLogoutAsync(CloudAgentLogoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudAgentLogoutWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席设置随路数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentSetUserDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentSetUserDataResponse
        /// </returns>
        public CloudAgentSetUserDataResponse CloudAgentSetUserDataWithOptions(CloudAgentSetUserDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudAgentSetUserData",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudAgentSetUserDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席设置随路数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentSetUserDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentSetUserDataResponse
        /// </returns>
        public async Task<CloudAgentSetUserDataResponse> CloudAgentSetUserDataWithOptionsAsync(CloudAgentSetUserDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                query["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudAgentSetUserData",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudAgentSetUserDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席设置随路数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentSetUserDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentSetUserDataResponse
        /// </returns>
        public CloudAgentSetUserDataResponse CloudAgentSetUserData(CloudAgentSetUserDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudAgentSetUserDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席设置随路数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentSetUserDataRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentSetUserDataResponse
        /// </returns>
        public async Task<CloudAgentSetUserDataResponse> CloudAgentSetUserDataAsync(CloudAgentSetUserDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudAgentSetUserDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席挂机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentUnlinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentUnlinkResponse
        /// </returns>
        public CloudAgentUnlinkResponse CloudAgentUnlinkWithOptions(CloudAgentUnlinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                query["Side"] = request.Side;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudAgentUnlink",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudAgentUnlinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席挂机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentUnlinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentUnlinkResponse
        /// </returns>
        public async Task<CloudAgentUnlinkResponse> CloudAgentUnlinkWithOptionsAsync(CloudAgentUnlinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                query["Side"] = request.Side;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudAgentUnlink",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudAgentUnlinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席挂机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentUnlinkRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentUnlinkResponse
        /// </returns>
        public CloudAgentUnlinkResponse CloudAgentUnlink(CloudAgentUnlinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudAgentUnlinkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席挂机</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudAgentUnlinkRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudAgentUnlinkResponse
        /// </returns>
        public async Task<CloudAgentUnlinkResponse> CloudAgentUnlinkAsync(CloudAgentUnlinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudAgentUnlinkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增座席,单次批量创建不能超过100个</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchCreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchCreateAgentResponse
        /// </returns>
        public CloudBatchCreateAgentResponse CloudBatchCreateAgentWithOptions(CloudBatchCreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCode))
            {
                query["AreaCode"] = request.AreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPower))
            {
                query["CallPower"] = request.CallPower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCno))
            {
                query["EndCno"] = request.EndCno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IbRecord))
            {
                query["IbRecord"] = request.IbRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsr))
            {
                query["IsAsr"] = request.IsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOb))
            {
                query["IsOb"] = request.IsOb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsQualityCheck))
            {
                query["IsQualityCheck"] = request.IsQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidProperty))
            {
                query["ObClidProperty"] = request.ObClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidType))
            {
                query["ObClidType"] = request.ObClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObRecord))
            {
                query["ObRecord"] = request.ObRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Power))
            {
                query["Power"] = request.Power;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillLevels))
            {
                query["SkillLevels"] = request.SkillLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudBatchCreateAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudBatchCreateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增座席,单次批量创建不能超过100个</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchCreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchCreateAgentResponse
        /// </returns>
        public async Task<CloudBatchCreateAgentResponse> CloudBatchCreateAgentWithOptionsAsync(CloudBatchCreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCode))
            {
                query["AreaCode"] = request.AreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPower))
            {
                query["CallPower"] = request.CallPower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCno))
            {
                query["EndCno"] = request.EndCno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IbRecord))
            {
                query["IbRecord"] = request.IbRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsr))
            {
                query["IsAsr"] = request.IsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOb))
            {
                query["IsOb"] = request.IsOb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsQualityCheck))
            {
                query["IsQualityCheck"] = request.IsQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidProperty))
            {
                query["ObClidProperty"] = request.ObClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidType))
            {
                query["ObClidType"] = request.ObClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObRecord))
            {
                query["ObRecord"] = request.ObRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Power))
            {
                query["Power"] = request.Power;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillLevels))
            {
                query["SkillLevels"] = request.SkillLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudBatchCreateAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudBatchCreateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增座席,单次批量创建不能超过100个</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchCreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchCreateAgentResponse
        /// </returns>
        public CloudBatchCreateAgentResponse CloudBatchCreateAgent(CloudBatchCreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudBatchCreateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量新增座席,单次批量创建不能超过100个</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchCreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchCreateAgentResponse
        /// </returns>
        public async Task<CloudBatchCreateAgentResponse> CloudBatchCreateAgentAsync(CloudBatchCreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudBatchCreateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席实时状态批量获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchGetAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchGetAgentStatusResponse
        /// </returns>
        public CloudBatchGetAgentStatusResponse CloudBatchGetAgentStatusWithOptions(CloudBatchGetAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudBatchGetAgentStatus",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudBatchGetAgentStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席实时状态批量获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchGetAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchGetAgentStatusResponse
        /// </returns>
        public async Task<CloudBatchGetAgentStatusResponse> CloudBatchGetAgentStatusWithOptionsAsync(CloudBatchGetAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudBatchGetAgentStatus",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudBatchGetAgentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席实时状态批量获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchGetAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchGetAgentStatusResponse
        /// </returns>
        public CloudBatchGetAgentStatusResponse CloudBatchGetAgentStatus(CloudBatchGetAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudBatchGetAgentStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席实时状态批量获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchGetAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchGetAgentStatusResponse
        /// </returns>
        public async Task<CloudBatchGetAgentStatusResponse> CloudBatchGetAgentStatusAsync(CloudBatchGetAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudBatchGetAgentStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新座席基本信息，不包含座席绑定的技能信息的更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchUpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchUpdateAgentResponse
        /// </returns>
        public CloudBatchUpdateAgentResponse CloudBatchUpdateAgentWithOptions(CloudBatchUpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCode))
            {
                query["AreaCode"] = request.AreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPower))
            {
                query["CallPower"] = request.CallPower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IbRecord))
            {
                query["IbRecord"] = request.IbRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsr))
            {
                query["IsAsr"] = request.IsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOb))
            {
                query["IsOb"] = request.IsOb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsObRemember))
            {
                query["IsObRemember"] = request.IsObRemember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsQualityCheck))
            {
                query["IsQualityCheck"] = request.IsQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRandom))
            {
                query["IsRandom"] = request.IsRandom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidProperty))
            {
                query["ObClidProperty"] = request.ObClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidType))
            {
                query["ObClidType"] = request.ObClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObRecord))
            {
                query["ObRecord"] = request.ObRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitObPreviewTime))
            {
                query["PermitObPreviewTime"] = request.PermitObPreviewTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Power))
            {
                query["Power"] = request.Power;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudBatchUpdateAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudBatchUpdateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新座席基本信息，不包含座席绑定的技能信息的更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchUpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchUpdateAgentResponse
        /// </returns>
        public async Task<CloudBatchUpdateAgentResponse> CloudBatchUpdateAgentWithOptionsAsync(CloudBatchUpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCode))
            {
                query["AreaCode"] = request.AreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPower))
            {
                query["CallPower"] = request.CallPower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IbRecord))
            {
                query["IbRecord"] = request.IbRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsr))
            {
                query["IsAsr"] = request.IsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOb))
            {
                query["IsOb"] = request.IsOb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsObRemember))
            {
                query["IsObRemember"] = request.IsObRemember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsQualityCheck))
            {
                query["IsQualityCheck"] = request.IsQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRandom))
            {
                query["IsRandom"] = request.IsRandom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidProperty))
            {
                query["ObClidProperty"] = request.ObClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidType))
            {
                query["ObClidType"] = request.ObClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObRecord))
            {
                query["ObRecord"] = request.ObRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitObPreviewTime))
            {
                query["PermitObPreviewTime"] = request.PermitObPreviewTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Power))
            {
                query["Power"] = request.Power;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudBatchUpdateAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudBatchUpdateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新座席基本信息，不包含座席绑定的技能信息的更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchUpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchUpdateAgentResponse
        /// </returns>
        public CloudBatchUpdateAgentResponse CloudBatchUpdateAgent(CloudBatchUpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudBatchUpdateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新座席基本信息，不包含座席绑定的技能信息的更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudBatchUpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudBatchUpdateAgentResponse
        /// </returns>
        public async Task<CloudBatchUpdateAgentResponse> CloudBatchUpdateAgentAsync(CloudBatchUpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudBatchUpdateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudCreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudCreateAgentResponse
        /// </returns>
        public CloudCreateAgentResponse CloudCreateAgentWithOptions(CloudCreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCode))
            {
                query["AreaCode"] = request.AreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPower))
            {
                query["CallPower"] = request.CallPower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IbRecord))
            {
                query["IbRecord"] = request.IbRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsr))
            {
                query["IsAsr"] = request.IsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOb))
            {
                query["IsOb"] = request.IsOb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsObRemember))
            {
                query["IsObRemember"] = request.IsObRemember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsQualityCheck))
            {
                query["IsQualityCheck"] = request.IsQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidProperty))
            {
                query["ObClidProperty"] = request.ObClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidType))
            {
                query["ObClidType"] = request.ObClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObRecord))
            {
                query["ObRecord"] = request.ObRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitObPreviewTime))
            {
                query["PermitObPreviewTime"] = request.PermitObPreviewTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Power))
            {
                query["Power"] = request.Power;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillLevels))
            {
                query["SkillLevels"] = request.SkillLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudCreateAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudCreateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudCreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudCreateAgentResponse
        /// </returns>
        public async Task<CloudCreateAgentResponse> CloudCreateAgentWithOptionsAsync(CloudCreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCode))
            {
                query["AreaCode"] = request.AreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPower))
            {
                query["CallPower"] = request.CallPower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IbRecord))
            {
                query["IbRecord"] = request.IbRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsr))
            {
                query["IsAsr"] = request.IsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOb))
            {
                query["IsOb"] = request.IsOb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsObRemember))
            {
                query["IsObRemember"] = request.IsObRemember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsQualityCheck))
            {
                query["IsQualityCheck"] = request.IsQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidProperty))
            {
                query["ObClidProperty"] = request.ObClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidType))
            {
                query["ObClidType"] = request.ObClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObRecord))
            {
                query["ObRecord"] = request.ObRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitObPreviewTime))
            {
                query["PermitObPreviewTime"] = request.PermitObPreviewTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Power))
            {
                query["Power"] = request.Power;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillLevels))
            {
                query["SkillLevels"] = request.SkillLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudCreateAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudCreateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudCreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudCreateAgentResponse
        /// </returns>
        public CloudCreateAgentResponse CloudCreateAgent(CloudCreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudCreateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudCreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudCreateAgentResponse
        /// </returns>
        public async Task<CloudCreateAgentResponse> CloudCreateAgentAsync(CloudCreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudCreateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudCreateTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudCreateTaskResponse
        /// </returns>
        public CloudCreateTaskResponse CloudCreateTaskWithOptions(CloudCreateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentGroup))
            {
                query["AgentGroup"] = request.AgentGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTimeout))
            {
                query["AgentTimeout"] = request.AgentTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerRate))
            {
                query["AnswerRate"] = request.AnswerRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoComplete))
            {
                query["AutoComplete"] = request.AutoComplete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDelete))
            {
                query["AutoDelete"] = request.AutoDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStart))
            {
                query["AutoStart"] = request.AutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartDay))
            {
                query["AutoStartDay"] = request.AutoStartDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartTime))
            {
                query["AutoStartTime"] = request.AutoStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStop))
            {
                query["AutoStop"] = request.AutoStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopDay))
            {
                query["AutoStopDay"] = request.AutoStopDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopTime))
            {
                query["AutoStopTime"] = request.AutoStopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTaskType))
            {
                query["AutoTaskType"] = request.AutoTaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTriggerTimeStrategy))
            {
                query["AutoTriggerTimeStrategy"] = request.AutoTriggerTimeStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallGroupType))
            {
                query["CallGroupType"] = request.CallGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallLimitStrategy))
            {
                query["CallLimitStrategy"] = request.CallLimitStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPriorityStrategy))
            {
                query["CallPriorityStrategy"] = request.CallPriorityStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRouteStrategy))
            {
                query["CallRouteStrategy"] = request.CallRouteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStrategy))
            {
                query["CallStrategy"] = request.CallStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallVariables))
            {
                query["CallVariables"] = request.CallVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidProperty))
            {
                query["ClidProperty"] = request.ClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidType))
            {
                query["CustomerClidType"] = request.CustomerClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidWeight))
            {
                query["CustomerClidWeight"] = request.CustomerClidWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidWeightFlag))
            {
                query["CustomerClidWeightFlag"] = request.CustomerClidWeightFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClids))
            {
                query["CustomerClids"] = request.CustomerClids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidsCategory))
            {
                query["CustomerClidsCategory"] = request.CustomerClidsCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidsGroup))
            {
                query["CustomerClidsGroup"] = request.CustomerClidsGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerMoh))
            {
                query["CustomerMoh"] = request.CustomerMoh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerTimeout))
            {
                query["CustomerTimeout"] = request.CustomerTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerVoice))
            {
                query["CustomerVoice"] = request.CustomerVoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceEndFlag))
            {
                query["ForceEndFlag"] = request.ForceEndFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRewarm))
            {
                query["IsRewarm"] = request.IsRewarm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrId))
            {
                query["IvrId"] = request.IvrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrName))
            {
                query["IvrName"] = request.IvrName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWaitTime))
            {
                query["MaxWaitTime"] = request.MaxWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAvailableAgentCount))
            {
                query["MinAvailableAgentCount"] = request.MinAvailableAgentCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictAdjust))
            {
                query["PredictAdjust"] = request.PredictAdjust;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quotiety))
            {
                query["Quotiety"] = request.Quotiety;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategy))
            {
                query["RetryStrategy"] = request.RetryStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategyOnlyToday))
            {
                query["RetryStrategyOnlyToday"] = request.RetryStrategyOnlyToday;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategyTimeType))
            {
                query["RetryStrategyTimeType"] = request.RetryStrategyTimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStrategy))
            {
                query["TimeStrategy"] = request.TimeStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFields))
            {
                query["UserFields"] = request.UserFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarmUpDuration))
            {
                query["WarmUpDuration"] = request.WarmUpDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudCreateTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudCreateTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudCreateTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudCreateTaskResponse
        /// </returns>
        public async Task<CloudCreateTaskResponse> CloudCreateTaskWithOptionsAsync(CloudCreateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentGroup))
            {
                query["AgentGroup"] = request.AgentGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTimeout))
            {
                query["AgentTimeout"] = request.AgentTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerRate))
            {
                query["AnswerRate"] = request.AnswerRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoComplete))
            {
                query["AutoComplete"] = request.AutoComplete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDelete))
            {
                query["AutoDelete"] = request.AutoDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStart))
            {
                query["AutoStart"] = request.AutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartDay))
            {
                query["AutoStartDay"] = request.AutoStartDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartTime))
            {
                query["AutoStartTime"] = request.AutoStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStop))
            {
                query["AutoStop"] = request.AutoStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopDay))
            {
                query["AutoStopDay"] = request.AutoStopDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopTime))
            {
                query["AutoStopTime"] = request.AutoStopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTaskType))
            {
                query["AutoTaskType"] = request.AutoTaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTriggerTimeStrategy))
            {
                query["AutoTriggerTimeStrategy"] = request.AutoTriggerTimeStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallGroupType))
            {
                query["CallGroupType"] = request.CallGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallLimitStrategy))
            {
                query["CallLimitStrategy"] = request.CallLimitStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPriorityStrategy))
            {
                query["CallPriorityStrategy"] = request.CallPriorityStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRouteStrategy))
            {
                query["CallRouteStrategy"] = request.CallRouteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStrategy))
            {
                query["CallStrategy"] = request.CallStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallVariables))
            {
                query["CallVariables"] = request.CallVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidProperty))
            {
                query["ClidProperty"] = request.ClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidType))
            {
                query["CustomerClidType"] = request.CustomerClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidWeight))
            {
                query["CustomerClidWeight"] = request.CustomerClidWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidWeightFlag))
            {
                query["CustomerClidWeightFlag"] = request.CustomerClidWeightFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClids))
            {
                query["CustomerClids"] = request.CustomerClids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidsCategory))
            {
                query["CustomerClidsCategory"] = request.CustomerClidsCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidsGroup))
            {
                query["CustomerClidsGroup"] = request.CustomerClidsGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerMoh))
            {
                query["CustomerMoh"] = request.CustomerMoh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerTimeout))
            {
                query["CustomerTimeout"] = request.CustomerTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerVoice))
            {
                query["CustomerVoice"] = request.CustomerVoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceEndFlag))
            {
                query["ForceEndFlag"] = request.ForceEndFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRewarm))
            {
                query["IsRewarm"] = request.IsRewarm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrId))
            {
                query["IvrId"] = request.IvrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrName))
            {
                query["IvrName"] = request.IvrName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWaitTime))
            {
                query["MaxWaitTime"] = request.MaxWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAvailableAgentCount))
            {
                query["MinAvailableAgentCount"] = request.MinAvailableAgentCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictAdjust))
            {
                query["PredictAdjust"] = request.PredictAdjust;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quotiety))
            {
                query["Quotiety"] = request.Quotiety;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategy))
            {
                query["RetryStrategy"] = request.RetryStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategyOnlyToday))
            {
                query["RetryStrategyOnlyToday"] = request.RetryStrategyOnlyToday;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategyTimeType))
            {
                query["RetryStrategyTimeType"] = request.RetryStrategyTimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStrategy))
            {
                query["TimeStrategy"] = request.TimeStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFields))
            {
                query["UserFields"] = request.UserFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarmUpDuration))
            {
                query["WarmUpDuration"] = request.WarmUpDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudCreateTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudCreateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudCreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudCreateTaskResponse
        /// </returns>
        public CloudCreateTaskResponse CloudCreateTask(CloudCreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudCreateTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudCreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudCreateTaskResponse
        /// </returns>
        public async Task<CloudCreateTaskResponse> CloudCreateTaskAsync(CloudCreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudCreateTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudDeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudDeleteAgentResponse
        /// </returns>
        public CloudDeleteAgentResponse CloudDeleteAgentWithOptions(CloudDeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudDeleteAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudDeleteAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudDeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudDeleteAgentResponse
        /// </returns>
        public async Task<CloudDeleteAgentResponse> CloudDeleteAgentWithOptionsAsync(CloudDeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudDeleteAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudDeleteAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudDeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudDeleteAgentResponse
        /// </returns>
        public CloudDeleteAgentResponse CloudDeleteAgent(CloudDeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudDeleteAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudDeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudDeleteAgentResponse
        /// </returns>
        public async Task<CloudDeleteAgentResponse> CloudDeleteAgentAsync(CloudDeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudDeleteAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除座席电话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudDeleteAgentTelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudDeleteAgentTelResponse
        /// </returns>
        public CloudDeleteAgentTelResponse CloudDeleteAgentTelWithOptions(CloudDeleteAgentTelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudDeleteAgentTel",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudDeleteAgentTelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除座席电话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudDeleteAgentTelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudDeleteAgentTelResponse
        /// </returns>
        public async Task<CloudDeleteAgentTelResponse> CloudDeleteAgentTelWithOptionsAsync(CloudDeleteAgentTelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudDeleteAgentTel",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudDeleteAgentTelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除座席电话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudDeleteAgentTelRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudDeleteAgentTelResponse
        /// </returns>
        public CloudDeleteAgentTelResponse CloudDeleteAgentTel(CloudDeleteAgentTelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudDeleteAgentTelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除座席电话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudDeleteAgentTelRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudDeleteAgentTelResponse
        /// </returns>
        public async Task<CloudDeleteAgentTelResponse> CloudDeleteAgentTelAsync(CloudDeleteAgentTelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudDeleteAgentTelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席详细信息获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudGetAgentResponse
        /// </returns>
        public CloudGetAgentResponse CloudGetAgentWithOptions(CloudGetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudGetAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudGetAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席详细信息获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudGetAgentResponse
        /// </returns>
        public async Task<CloudGetAgentResponse> CloudGetAgentWithOptionsAsync(CloudGetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudGetAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudGetAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席详细信息获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudGetAgentResponse
        /// </returns>
        public CloudGetAgentResponse CloudGetAgent(CloudGetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudGetAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席详细信息获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudGetAgentResponse
        /// </returns>
        public async Task<CloudGetAgentResponse> CloudGetAgentAsync(CloudGetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudGetAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席实时状态获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudGetAgentStatusResponse
        /// </returns>
        public CloudGetAgentStatusResponse CloudGetAgentStatusWithOptions(CloudGetAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudGetAgentStatus",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudGetAgentStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席实时状态获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudGetAgentStatusResponse
        /// </returns>
        public async Task<CloudGetAgentStatusResponse> CloudGetAgentStatusWithOptionsAsync(CloudGetAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudGetAgentStatus",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudGetAgentStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席实时状态获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudGetAgentStatusResponse
        /// </returns>
        public CloudGetAgentStatusResponse CloudGetAgentStatus(CloudGetAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudGetAgentStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席实时状态获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudGetAgentStatusResponse
        /// </returns>
        public async Task<CloudGetAgentStatusResponse> CloudGetAgentStatusAsync(CloudGetAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudGetAgentStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼通话记录详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetObCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudGetObCdrResponse
        /// </returns>
        public CloudGetObCdrResponse CloudGetObCdrWithOptions(CloudGetObCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudGetObCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudGetObCdrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼通话记录详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetObCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudGetObCdrResponse
        /// </returns>
        public async Task<CloudGetObCdrResponse> CloudGetObCdrWithOptionsAsync(CloudGetObCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudGetObCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudGetObCdrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼通话记录详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetObCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudGetObCdrResponse
        /// </returns>
        public CloudGetObCdrResponse CloudGetObCdr(CloudGetObCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudGetObCdrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼通话记录详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetObCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudGetObCdrResponse
        /// </returns>
        public async Task<CloudGetObCdrResponse> CloudGetObCdrAsync(CloudGetObCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudGetObCdrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通话录音地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetRecordUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudGetRecordUrlResponse
        /// </returns>
        public CloudGetRecordUrlResponse CloudGetRecordUrlWithOptions(CloudGetRecordUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                query["CallType"] = request.CallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Download))
            {
                query["Download"] = request.Download;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFile))
            {
                query["RecordFile"] = request.RecordFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFormat))
            {
                query["RecordFormat"] = request.RecordFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordSide))
            {
                query["RecordSide"] = request.RecordSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordType))
            {
                query["RecordType"] = request.RecordType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudGetRecordUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudGetRecordUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通话录音地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetRecordUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudGetRecordUrlResponse
        /// </returns>
        public async Task<CloudGetRecordUrlResponse> CloudGetRecordUrlWithOptionsAsync(CloudGetRecordUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                query["CallType"] = request.CallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Download))
            {
                query["Download"] = request.Download;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFile))
            {
                query["RecordFile"] = request.RecordFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFormat))
            {
                query["RecordFormat"] = request.RecordFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordSide))
            {
                query["RecordSide"] = request.RecordSide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordType))
            {
                query["RecordType"] = request.RecordType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudGetRecordUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudGetRecordUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通话录音地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetRecordUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudGetRecordUrlResponse
        /// </returns>
        public CloudGetRecordUrlResponse CloudGetRecordUrl(CloudGetRecordUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudGetRecordUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取通话录音地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudGetRecordUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudGetRecordUrlResponse
        /// </returns>
        public async Task<CloudGetRecordUrlResponse> CloudGetRecordUrlAsync(CloudGetRecordUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudGetRecordUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务号码导入</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloudImportTaskTelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudImportTaskTelResponse
        /// </returns>
        public CloudImportTaskTelResponse CloudImportTaskTelWithOptions(CloudImportTaskTelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloudImportTaskTelShrinkRequest request = new CloudImportTaskTelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskTelList))
            {
                request.TaskTelListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskTelList, "TaskTelList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BridgeVoicePath))
            {
                query["BridgeVoicePath"] = request.BridgeVoicePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BridgeVoiceType))
            {
                query["BridgeVoiceType"] = request.BridgeVoiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportTelAutoStart))
            {
                query["ImportTelAutoStart"] = request.ImportTelAutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRepeat))
            {
                query["IsRepeat"] = request.IsRepeat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTelListShrink))
            {
                query["TaskTelList"] = request.TaskTelListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudImportTaskTel",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudImportTaskTelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务号码导入</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloudImportTaskTelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudImportTaskTelResponse
        /// </returns>
        public async Task<CloudImportTaskTelResponse> CloudImportTaskTelWithOptionsAsync(CloudImportTaskTelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloudImportTaskTelShrinkRequest request = new CloudImportTaskTelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TaskTelList))
            {
                request.TaskTelListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TaskTelList, "TaskTelList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BridgeVoicePath))
            {
                query["BridgeVoicePath"] = request.BridgeVoicePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BridgeVoiceType))
            {
                query["BridgeVoiceType"] = request.BridgeVoiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                query["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportTelAutoStart))
            {
                query["ImportTelAutoStart"] = request.ImportTelAutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRepeat))
            {
                query["IsRepeat"] = request.IsRepeat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTelListShrink))
            {
                query["TaskTelList"] = request.TaskTelListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudImportTaskTel",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudImportTaskTelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务号码导入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudImportTaskTelRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudImportTaskTelResponse
        /// </returns>
        public CloudImportTaskTelResponse CloudImportTaskTel(CloudImportTaskTelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudImportTaskTelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务号码导入</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudImportTaskTelRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudImportTaskTelResponse
        /// </returns>
        public async Task<CloudImportTaskTelResponse> CloudImportTaskTelAsync(CloudImportTaskTelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudImportTaskTelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>IVR等待打断</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudInterruptIvrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudInterruptIvrResponse
        /// </returns>
        public CloudInterruptIvrResponse CloudInterruptIvrWithOptions(CloudInterruptIvrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckName))
            {
                query["CheckName"] = request.CheckName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckValue))
            {
                query["CheckValue"] = request.CheckValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserField))
            {
                query["UserField"] = request.UserField;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudInterruptIvr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudInterruptIvrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>IVR等待打断</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudInterruptIvrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudInterruptIvrResponse
        /// </returns>
        public async Task<CloudInterruptIvrResponse> CloudInterruptIvrWithOptionsAsync(CloudInterruptIvrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckName))
            {
                query["CheckName"] = request.CheckName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckValue))
            {
                query["CheckValue"] = request.CheckValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserField))
            {
                query["UserField"] = request.UserField;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudInterruptIvr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudInterruptIvrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>IVR等待打断</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudInterruptIvrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudInterruptIvrResponse
        /// </returns>
        public CloudInterruptIvrResponse CloudInterruptIvr(CloudInterruptIvrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudInterruptIvrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>IVR等待打断</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudInterruptIvrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudInterruptIvrResponse
        /// </returns>
        public async Task<CloudInterruptIvrResponse> CloudInterruptIvrAsync(CloudInterruptIvrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudInterruptIvrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席电话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListAgentTelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudListAgentTelResponse
        /// </returns>
        public CloudListAgentTelResponse CloudListAgentTelWithOptions(CloudListAgentTelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudListAgentTel",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudListAgentTelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席电话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListAgentTelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudListAgentTelResponse
        /// </returns>
        public async Task<CloudListAgentTelResponse> CloudListAgentTelWithOptionsAsync(CloudListAgentTelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudListAgentTel",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudListAgentTelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席电话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListAgentTelRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudListAgentTelResponse
        /// </returns>
        public CloudListAgentTelResponse CloudListAgentTel(CloudListAgentTelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudListAgentTelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席电话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListAgentTelRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudListAgentTelResponse
        /// </returns>
        public async Task<CloudListAgentTelResponse> CloudListAgentTelAsync(CloudListAgentTelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudListAgentTelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取在线空闲座席</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListFreeAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudListFreeAgentResponse
        /// </returns>
        public CloudListFreeAgentResponse CloudListFreeAgentWithOptions(CloudListFreeAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudListFreeAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudListFreeAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取在线空闲座席</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListFreeAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudListFreeAgentResponse
        /// </returns>
        public async Task<CloudListFreeAgentResponse> CloudListFreeAgentWithOptionsAsync(CloudListFreeAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudListFreeAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudListFreeAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取在线空闲座席</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListFreeAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudListFreeAgentResponse
        /// </returns>
        public CloudListFreeAgentResponse CloudListFreeAgent(CloudListFreeAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudListFreeAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取在线空闲座席</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListFreeAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudListFreeAgentResponse
        /// </returns>
        public async Task<CloudListFreeAgentResponse> CloudListFreeAgentAsync(CloudListFreeAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudListFreeAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线座席信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListOnlineAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudListOnlineAgentResponse
        /// </returns>
        public CloudListOnlineAgentResponse CloudListOnlineAgentWithOptions(CloudListOnlineAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseDescription))
            {
                query["PauseDescription"] = request.PauseDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseType))
            {
                query["PauseType"] = request.PauseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qnos))
            {
                query["Qnos"] = request.Qnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateCode))
            {
                query["StateCode"] = request.StateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudListOnlineAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudListOnlineAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线座席信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListOnlineAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudListOnlineAgentResponse
        /// </returns>
        public async Task<CloudListOnlineAgentResponse> CloudListOnlineAgentWithOptionsAsync(CloudListOnlineAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseDescription))
            {
                query["PauseDescription"] = request.PauseDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseType))
            {
                query["PauseType"] = request.PauseType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qnos))
            {
                query["Qnos"] = request.Qnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StateCode))
            {
                query["StateCode"] = request.StateCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudListOnlineAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudListOnlineAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线座席信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListOnlineAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudListOnlineAgentResponse
        /// </returns>
        public CloudListOnlineAgentResponse CloudListOnlineAgent(CloudListOnlineAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudListOnlineAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在线座席信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudListOnlineAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudListOnlineAgentResponse
        /// </returns>
        public async Task<CloudListOnlineAgentResponse> CloudListOnlineAgentAsync(CloudListOnlineAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudListOnlineAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预览外呼主叫号码报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudOutboundObClidReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudOutboundObClidReportResponse
        /// </returns>
        public CloudOutboundObClidReportResponse CloudOutboundObClidReportWithOptions(CloudOutboundObClidReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCodes))
            {
                query["AreaCodes"] = request.AreaCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndHour))
            {
                query["EndHour"] = request.EndHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartHour))
            {
                query["StartHour"] = request.StartHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticMethod))
            {
                query["StatisticMethod"] = request.StatisticMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudOutboundObClidReport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudOutboundObClidReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预览外呼主叫号码报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudOutboundObClidReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudOutboundObClidReportResponse
        /// </returns>
        public async Task<CloudOutboundObClidReportResponse> CloudOutboundObClidReportWithOptionsAsync(CloudOutboundObClidReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCodes))
            {
                query["AreaCodes"] = request.AreaCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndHour))
            {
                query["EndHour"] = request.EndHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartHour))
            {
                query["StartHour"] = request.StartHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticMethod))
            {
                query["StatisticMethod"] = request.StatisticMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudOutboundObClidReport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudOutboundObClidReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预览外呼主叫号码报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudOutboundObClidReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudOutboundObClidReportResponse
        /// </returns>
        public CloudOutboundObClidReportResponse CloudOutboundObClidReport(CloudOutboundObClidReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudOutboundObClidReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预览外呼主叫号码报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudOutboundObClidReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudOutboundObClidReportResponse
        /// </returns>
        public async Task<CloudOutboundObClidReportResponse> CloudOutboundObClidReportAsync(CloudOutboundObClidReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudOutboundObClidReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预览外呼报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudOutboundPreviewObReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudOutboundPreviewObReportResponse
        /// </returns>
        public CloudOutboundPreviewObReportResponse CloudOutboundPreviewObReportWithOptions(CloudOutboundPreviewObReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndHour))
            {
                query["EndHour"] = request.EndHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartHour))
            {
                query["StartHour"] = request.StartHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticMethod))
            {
                query["StatisticMethod"] = request.StatisticMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudOutboundPreviewObReport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudOutboundPreviewObReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预览外呼报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudOutboundPreviewObReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudOutboundPreviewObReportResponse
        /// </returns>
        public async Task<CloudOutboundPreviewObReportResponse> CloudOutboundPreviewObReportWithOptionsAsync(CloudOutboundPreviewObReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndHour))
            {
                query["EndHour"] = request.EndHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartHour))
            {
                query["StartHour"] = request.StartHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticMethod))
            {
                query["StatisticMethod"] = request.StatisticMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudOutboundPreviewObReport",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudOutboundPreviewObReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预览外呼报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudOutboundPreviewObReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudOutboundPreviewObReportResponse
        /// </returns>
        public CloudOutboundPreviewObReportResponse CloudOutboundPreviewObReport(CloudOutboundPreviewObReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudOutboundPreviewObReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预览外呼报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudOutboundPreviewObReportRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudOutboundPreviewObReportResponse
        /// </returns>
        public async Task<CloudOutboundPreviewObReportResponse> CloudOutboundPreviewObReportAsync(CloudOutboundPreviewObReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudOutboundPreviewObReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudPreviewoutcallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudPreviewoutcallResponse
        /// </returns>
        public CloudPreviewoutcallResponse CloudPreviewoutcallWithOptions(CloudPreviewoutcallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTels))
            {
                query["BackupTels"] = request.BackupTels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallVariables))
            {
                query["CallVariables"] = request.CallVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CdrIsAsr))
            {
                query["CdrIsAsr"] = request.CdrIsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidList))
            {
                query["ClidList"] = request.ClidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrnId))
            {
                query["CrnId"] = request.CrnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialTelTimeout))
            {
                query["DialTelTimeout"] = request.DialTelTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInvestigation))
            {
                query["IsInvestigation"] = request.IsInvestigation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidAreaCode))
            {
                query["ObClidAreaCode"] = request.ObClidAreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidGroup))
            {
                query["ObClidGroup"] = request.ObClidGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudPreviewoutcall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudPreviewoutcallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudPreviewoutcallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudPreviewoutcallResponse
        /// </returns>
        public async Task<CloudPreviewoutcallResponse> CloudPreviewoutcallWithOptionsAsync(CloudPreviewoutcallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupTels))
            {
                query["BackupTels"] = request.BackupTels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallVariables))
            {
                query["CallVariables"] = request.CallVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CdrIsAsr))
            {
                query["CdrIsAsr"] = request.CdrIsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidList))
            {
                query["ClidList"] = request.ClidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrnId))
            {
                query["CrnId"] = request.CrnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialTelTimeout))
            {
                query["DialTelTimeout"] = request.DialTelTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInvestigation))
            {
                query["IsInvestigation"] = request.IsInvestigation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidAreaCode))
            {
                query["ObClidAreaCode"] = request.ObClidAreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidGroup))
            {
                query["ObClidGroup"] = request.ObClidGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudPreviewoutcall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudPreviewoutcallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudPreviewoutcallRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudPreviewoutcallResponse
        /// </returns>
        public CloudPreviewoutcallResponse CloudPreviewoutcall(CloudPreviewoutcallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudPreviewoutcallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudPreviewoutcallRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudPreviewoutcallResponse
        /// </returns>
        public async Task<CloudPreviewoutcallResponse> CloudPreviewoutcallAsync(CloudPreviewoutcallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudPreviewoutcallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席详细信息列表获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentResponse
        /// </returns>
        public CloudQueryAgentResponse CloudQueryAgentWithOptions(CloudQueryAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qno))
            {
                query["Qno"] = request.Qno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnQueue))
            {
                query["ReturnQueue"] = request.ReturnQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席详细信息列表获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentResponse
        /// </returns>
        public async Task<CloudQueryAgentResponse> CloudQueryAgentWithOptionsAsync(CloudQueryAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qno))
            {
                query["Qno"] = request.Qno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnQueue))
            {
                query["ReturnQueue"] = request.ReturnQueue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席详细信息列表获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentResponse
        /// </returns>
        public CloudQueryAgentResponse CloudQueryAgent(CloudQueryAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudQueryAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席详细信息列表获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentResponse
        /// </returns>
        public async Task<CloudQueryAgentResponse> CloudQueryAgentAsync(CloudQueryAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudQueryAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席列表获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentCnoAndNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentCnoAndNameResponse
        /// </returns>
        public CloudQueryAgentCnoAndNameResponse CloudQueryAgentCnoAndNameWithOptions(CloudQueryAgentCnoAndNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryAgentCnoAndName",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryAgentCnoAndNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席列表获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentCnoAndNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentCnoAndNameResponse
        /// </returns>
        public async Task<CloudQueryAgentCnoAndNameResponse> CloudQueryAgentCnoAndNameWithOptionsAsync(CloudQueryAgentCnoAndNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryAgentCnoAndName",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryAgentCnoAndNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席列表获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentCnoAndNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentCnoAndNameResponse
        /// </returns>
        public CloudQueryAgentCnoAndNameResponse CloudQueryAgentCnoAndName(CloudQueryAgentCnoAndNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudQueryAgentCnoAndNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席列表获取</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentCnoAndNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentCnoAndNameResponse
        /// </returns>
        public async Task<CloudQueryAgentCnoAndNameResponse> CloudQueryAgentCnoAndNameAsync(CloudQueryAgentCnoAndNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudQueryAgentCnoAndNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentGroupResponse
        /// </returns>
        public CloudQueryAgentGroupResponse CloudQueryAgentGroupWithOptions(CloudQueryAgentGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryAgentGroup",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryAgentGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentGroupResponse
        /// </returns>
        public async Task<CloudQueryAgentGroupResponse> CloudQueryAgentGroupWithOptionsAsync(CloudQueryAgentGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryAgentGroup",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryAgentGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentGroupResponse
        /// </returns>
        public CloudQueryAgentGroupResponse CloudQueryAgentGroup(CloudQueryAgentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudQueryAgentGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentGroupResponse
        /// </returns>
        public async Task<CloudQueryAgentGroupResponse> CloudQueryAgentGroupAsync(CloudQueryAgentGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudQueryAgentGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentSkillResponse
        /// </returns>
        public CloudQueryAgentSkillResponse CloudQueryAgentSkillWithOptions(CloudQueryAgentSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryAgentSkill",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryAgentSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentSkillResponse
        /// </returns>
        public async Task<CloudQueryAgentSkillResponse> CloudQueryAgentSkillWithOptionsAsync(CloudQueryAgentSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryAgentSkill",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryAgentSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentSkillResponse
        /// </returns>
        public CloudQueryAgentSkillResponse CloudQueryAgentSkill(CloudQueryAgentSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudQueryAgentSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryAgentSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryAgentSkillResponse
        /// </returns>
        public async Task<CloudQueryAgentSkillResponse> CloudQueryAgentSkillAsync(CloudQueryAgentSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudQueryAgentSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来电通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryIbCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryIbCdrResponse
        /// </returns>
        public CloudQueryIbCdrResponse CloudQueryIbCdrWithOptions(CloudQueryIbCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeNumber))
            {
                query["CalleeNumber"] = request.CalleeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNumber))
            {
                query["CustomerNumber"] = request.CustomerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hotline))
            {
                query["Hotline"] = request.Hotline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinQueueCode))
            {
                query["JoinQueueCode"] = request.JoinQueueCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveQueueCode))
            {
                query["LeaveQueueCode"] = request.LeaveQueueCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qno))
            {
                query["Qno"] = request.Qno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldValue))
            {
                query["UserFieldValue"] = request.UserFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldkey))
            {
                query["UserFieldkey"] = request.UserFieldkey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryIbCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryIbCdrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来电通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryIbCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryIbCdrResponse
        /// </returns>
        public async Task<CloudQueryIbCdrResponse> CloudQueryIbCdrWithOptionsAsync(CloudQueryIbCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeNumber))
            {
                query["CalleeNumber"] = request.CalleeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNumber))
            {
                query["CustomerNumber"] = request.CustomerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hotline))
            {
                query["Hotline"] = request.Hotline;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JoinQueueCode))
            {
                query["JoinQueueCode"] = request.JoinQueueCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeaveQueueCode))
            {
                query["LeaveQueueCode"] = request.LeaveQueueCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qno))
            {
                query["Qno"] = request.Qno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldValue))
            {
                query["UserFieldValue"] = request.UserFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldkey))
            {
                query["UserFieldkey"] = request.UserFieldkey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryIbCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryIbCdrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来电通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryIbCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryIbCdrResponse
        /// </returns>
        public CloudQueryIbCdrResponse CloudQueryIbCdr(CloudQueryIbCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudQueryIbCdrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>来电通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryIbCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryIbCdrResponse
        /// </returns>
        public async Task<CloudQueryIbCdrResponse> CloudQueryIbCdrAsync(CloudQueryIbCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudQueryIbCdrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryObCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryObCdrResponse
        /// </returns>
        public CloudQueryObCdrResponse CloudQueryObCdrWithOptions(CloudQueryObCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                query["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentNumber))
            {
                query["AgentNumber"] = request.AgentNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                query["CallType"] = request.CallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clid))
            {
                query["Clid"] = request.Clid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNumber))
            {
                query["CustomerNumber"] = request.CustomerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownGrade))
            {
                query["DownGrade"] = request.DownGrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gno))
            {
                query["Gno"] = request.Gno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRealAnswer))
            {
                query["IsRealAnswer"] = request.IsRealAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeftDisplayNumber))
            {
                query["LeftDisplayNumber"] = request.LeftDisplayNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCount))
            {
                query["ReturnCount"] = request.ReturnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldValue))
            {
                query["UserFieldValue"] = request.UserFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldkey))
            {
                query["UserFieldkey"] = request.UserFieldkey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryObCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryObCdrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryObCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryObCdrResponse
        /// </returns>
        public async Task<CloudQueryObCdrResponse> CloudQueryObCdrWithOptionsAsync(CloudQueryObCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                query["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentNumber))
            {
                query["AgentNumber"] = request.AgentNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallType))
            {
                query["CallType"] = request.CallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clid))
            {
                query["Clid"] = request.Clid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNumber))
            {
                query["CustomerNumber"] = request.CustomerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownGrade))
            {
                query["DownGrade"] = request.DownGrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gno))
            {
                query["Gno"] = request.Gno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRealAnswer))
            {
                query["IsRealAnswer"] = request.IsRealAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LeftDisplayNumber))
            {
                query["LeftDisplayNumber"] = request.LeftDisplayNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCount))
            {
                query["ReturnCount"] = request.ReturnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldValue))
            {
                query["UserFieldValue"] = request.UserFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldkey))
            {
                query["UserFieldkey"] = request.UserFieldkey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryObCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryObCdrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryObCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryObCdrResponse
        /// </returns>
        public CloudQueryObCdrResponse CloudQueryObCdr(CloudQueryObCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudQueryObCdrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取座席外呼通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryObCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryObCdrResponse
        /// </returns>
        public async Task<CloudQueryObCdrResponse> CloudQueryObCdrAsync(CloudQueryObCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudQueryObCdrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预测式外呼通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryPredictiveCallCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryPredictiveCallCdrResponse
        /// </returns>
        public CloudQueryPredictiveCallCdrResponse CloudQueryPredictiveCallCdrWithOptions(CloudQueryPredictiveCallCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                query["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clid))
            {
                query["Clid"] = request.Clid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNumber))
            {
                query["CustomerNumber"] = request.CustomerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayNumber))
            {
                query["DisplayNumber"] = request.DisplayNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownGrade))
            {
                query["DownGrade"] = request.DownGrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gno))
            {
                query["Gno"] = request.Gno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRealAnswer))
            {
                query["IsRealAnswer"] = request.IsRealAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskFileId))
            {
                query["TaskFileId"] = request.TaskFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldValue))
            {
                query["UserFieldValue"] = request.UserFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldkey))
            {
                query["UserFieldkey"] = request.UserFieldkey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryPredictiveCallCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryPredictiveCallCdrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预测式外呼通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryPredictiveCallCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryPredictiveCallCdrResponse
        /// </returns>
        public async Task<CloudQueryPredictiveCallCdrResponse> CloudQueryPredictiveCallCdrWithOptionsAsync(CloudQueryPredictiveCallCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentName))
            {
                query["AgentName"] = request.AgentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clid))
            {
                query["Clid"] = request.Clid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNumber))
            {
                query["CustomerNumber"] = request.CustomerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayNumber))
            {
                query["DisplayNumber"] = request.DisplayNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownGrade))
            {
                query["DownGrade"] = request.DownGrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gno))
            {
                query["Gno"] = request.Gno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRealAnswer))
            {
                query["IsRealAnswer"] = request.IsRealAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskFileId))
            {
                query["TaskFileId"] = request.TaskFileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldValue))
            {
                query["UserFieldValue"] = request.UserFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldkey))
            {
                query["UserFieldkey"] = request.UserFieldkey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryPredictiveCallCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryPredictiveCallCdrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预测式外呼通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryPredictiveCallCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryPredictiveCallCdrResponse
        /// </returns>
        public CloudQueryPredictiveCallCdrResponse CloudQueryPredictiveCallCdr(CloudQueryPredictiveCallCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudQueryPredictiveCallCdrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预测式外呼通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryPredictiveCallCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryPredictiveCallCdrResponse
        /// </returns>
        public async Task<CloudQueryPredictiveCallCdrResponse> CloudQueryPredictiveCallCdrAsync(CloudQueryPredictiveCallCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudQueryPredictiveCallCdrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>webcall通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryWebcallCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryWebcallCdrResponse
        /// </returns>
        public CloudQueryWebcallCdrResponse CloudQueryWebcallCdrWithOptions(CloudQueryWebcallCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeClid))
            {
                query["CalleeClid"] = request.CalleeClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeDisplayNumber))
            {
                query["CalleeDisplayNumber"] = request.CalleeDisplayNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeNumber))
            {
                query["CalleeNumber"] = request.CalleeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clid))
            {
                query["Clid"] = request.Clid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNumber))
            {
                query["CustomerNumber"] = request.CustomerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayNumber))
            {
                query["DisplayNumber"] = request.DisplayNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gno))
            {
                query["Gno"] = request.Gno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRealAnswer))
            {
                query["IsRealAnswer"] = request.IsRealAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCount))
            {
                query["ReturnCount"] = request.ReturnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldValue))
            {
                query["UserFieldValue"] = request.UserFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldkey))
            {
                query["UserFieldkey"] = request.UserFieldkey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryWebcallCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryWebcallCdrResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>webcall通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryWebcallCdrRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryWebcallCdrResponse
        /// </returns>
        public async Task<CloudQueryWebcallCdrResponse> CloudQueryWebcallCdrWithOptionsAsync(CloudQueryWebcallCdrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeClid))
            {
                query["CalleeClid"] = request.CalleeClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeDisplayNumber))
            {
                query["CalleeDisplayNumber"] = request.CalleeDisplayNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalleeNumber))
            {
                query["CalleeNumber"] = request.CalleeNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clid))
            {
                query["Clid"] = request.Clid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerNumber))
            {
                query["CustomerNumber"] = request.CustomerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayNumber))
            {
                query["DisplayNumber"] = request.DisplayNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gno))
            {
                query["Gno"] = request.Gno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRealAnswer))
            {
                query["IsRealAnswer"] = request.IsRealAnswer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnCount))
            {
                query["ReturnCount"] = request.ReturnCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Start))
            {
                query["Start"] = request.Start;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRangeType))
            {
                query["TimeRangeType"] = request.TimeRangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldValue))
            {
                query["UserFieldValue"] = request.UserFieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFieldkey))
            {
                query["UserFieldkey"] = request.UserFieldkey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudQueryWebcallCdr",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudQueryWebcallCdrResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>webcall通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryWebcallCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryWebcallCdrResponse
        /// </returns>
        public CloudQueryWebcallCdrResponse CloudQueryWebcallCdr(CloudQueryWebcallCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudQueryWebcallCdrWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>webcall通话记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudQueryWebcallCdrRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudQueryWebcallCdrResponse
        /// </returns>
        public async Task<CloudQueryWebcallCdrResponse> CloudQueryWebcallCdrAsync(CloudQueryWebcallCdrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudQueryWebcallCdrWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务启动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudStartTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudStartTaskResponse
        /// </returns>
        public CloudStartTaskResponse CloudStartTaskWithOptions(CloudStartTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudStartTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudStartTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务启动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudStartTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudStartTaskResponse
        /// </returns>
        public async Task<CloudStartTaskResponse> CloudStartTaskWithOptionsAsync(CloudStartTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudStartTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudStartTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务启动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudStartTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudStartTaskResponse
        /// </returns>
        public CloudStartTaskResponse CloudStartTask(CloudStartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudStartTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务启动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudStartTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudStartTaskResponse
        /// </returns>
        public async Task<CloudStartTaskResponse> CloudStartTaskAsync(CloudStartTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudStartTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudUpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudUpdateAgentResponse
        /// </returns>
        public CloudUpdateAgentResponse CloudUpdateAgentWithOptions(CloudUpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCode))
            {
                query["AreaCode"] = request.AreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPower))
            {
                query["CallPower"] = request.CallPower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IbRecord))
            {
                query["IbRecord"] = request.IbRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsr))
            {
                query["IsAsr"] = request.IsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOb))
            {
                query["IsOb"] = request.IsOb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsObRemember))
            {
                query["IsObRemember"] = request.IsObRemember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsQualityCheck))
            {
                query["IsQualityCheck"] = request.IsQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRandom))
            {
                query["IsRandom"] = request.IsRandom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidProperty))
            {
                query["ObClidProperty"] = request.ObClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidType))
            {
                query["ObClidType"] = request.ObClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObRecord))
            {
                query["ObRecord"] = request.ObRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitObPreviewTime))
            {
                query["PermitObPreviewTime"] = request.PermitObPreviewTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Power))
            {
                query["Power"] = request.Power;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillLevels))
            {
                query["SkillLevels"] = request.SkillLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudUpdateAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudUpdateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudUpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudUpdateAgentResponse
        /// </returns>
        public async Task<CloudUpdateAgentResponse> CloudUpdateAgentWithOptionsAsync(CloudUpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                query["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentType))
            {
                query["AgentType"] = request.AgentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AreaCode))
            {
                query["AreaCode"] = request.AreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPower))
            {
                query["CallPower"] = request.CallPower;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cno))
            {
                query["Cno"] = request.Cno;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["Comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IbRecord))
            {
                query["IbRecord"] = request.IbRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAsr))
            {
                query["IsAsr"] = request.IsAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOb))
            {
                query["IsOb"] = request.IsOb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsObRemember))
            {
                query["IsObRemember"] = request.IsObRemember;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsQualityCheck))
            {
                query["IsQualityCheck"] = request.IsQualityCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRandom))
            {
                query["IsRandom"] = request.IsRandom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClid))
            {
                query["ObClid"] = request.ObClid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidProperty))
            {
                query["ObClidProperty"] = request.ObClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObClidType))
            {
                query["ObClidType"] = request.ObClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObRecord))
            {
                query["ObRecord"] = request.ObRecord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitObPreviewTime))
            {
                query["PermitObPreviewTime"] = request.PermitObPreviewTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Power))
            {
                query["Power"] = request.Power;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIds))
            {
                query["SkillIds"] = request.SkillIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillLevels))
            {
                query["SkillLevels"] = request.SkillLevels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebrtcUrlType))
            {
                query["WebrtcUrlType"] = request.WebrtcUrlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudUpdateAgent",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudUpdateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudUpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudUpdateAgentResponse
        /// </returns>
        public CloudUpdateAgentResponse CloudUpdateAgent(CloudUpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudUpdateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>座席更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudUpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudUpdateAgentResponse
        /// </returns>
        public async Task<CloudUpdateAgentResponse> CloudUpdateAgentAsync(CloudUpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudUpdateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudUpdateTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudUpdateTaskResponse
        /// </returns>
        public CloudUpdateTaskResponse CloudUpdateTaskWithOptions(CloudUpdateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentGroup))
            {
                query["AgentGroup"] = request.AgentGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTimeout))
            {
                query["AgentTimeout"] = request.AgentTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerRate))
            {
                query["AnswerRate"] = request.AnswerRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoComplete))
            {
                query["AutoComplete"] = request.AutoComplete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStart))
            {
                query["AutoStart"] = request.AutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartDay))
            {
                query["AutoStartDay"] = request.AutoStartDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartTime))
            {
                query["AutoStartTime"] = request.AutoStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStop))
            {
                query["AutoStop"] = request.AutoStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopDay))
            {
                query["AutoStopDay"] = request.AutoStopDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopTime))
            {
                query["AutoStopTime"] = request.AutoStopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTaskType))
            {
                query["AutoTaskType"] = request.AutoTaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTriggerTimeStrategy))
            {
                query["AutoTriggerTimeStrategy"] = request.AutoTriggerTimeStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallLimitStrategy))
            {
                query["CallLimitStrategy"] = request.CallLimitStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPriorityStrategy))
            {
                query["CallPriorityStrategy"] = request.CallPriorityStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRouteStrategy))
            {
                query["CallRouteStrategy"] = request.CallRouteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStrategy))
            {
                query["CallStrategy"] = request.CallStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallVariables))
            {
                query["CallVariables"] = request.CallVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidProperty))
            {
                query["ClidProperty"] = request.ClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidType))
            {
                query["CustomerClidType"] = request.CustomerClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidWeight))
            {
                query["CustomerClidWeight"] = request.CustomerClidWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidWeightFlag))
            {
                query["CustomerClidWeightFlag"] = request.CustomerClidWeightFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClids))
            {
                query["CustomerClids"] = request.CustomerClids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidsCategory))
            {
                query["CustomerClidsCategory"] = request.CustomerClidsCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidsGroup))
            {
                query["CustomerClidsGroup"] = request.CustomerClidsGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerMoh))
            {
                query["CustomerMoh"] = request.CustomerMoh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerTimeout))
            {
                query["CustomerTimeout"] = request.CustomerTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerVoice))
            {
                query["CustomerVoice"] = request.CustomerVoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceEndFlag))
            {
                query["ForceEndFlag"] = request.ForceEndFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRewarm))
            {
                query["IsRewarm"] = request.IsRewarm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrId))
            {
                query["IvrId"] = request.IvrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrName))
            {
                query["IvrName"] = request.IvrName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWaitTime))
            {
                query["MaxWaitTime"] = request.MaxWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAvailableAgentCount))
            {
                query["MinAvailableAgentCount"] = request.MinAvailableAgentCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictAdjust))
            {
                query["PredictAdjust"] = request.PredictAdjust;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quotiety))
            {
                query["Quotiety"] = request.Quotiety;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategy))
            {
                query["RetryStrategy"] = request.RetryStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategyOnlyToday))
            {
                query["RetryStrategyOnlyToday"] = request.RetryStrategyOnlyToday;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategyTimeType))
            {
                query["RetryStrategyTimeType"] = request.RetryStrategyTimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStrategy))
            {
                query["TimeStrategy"] = request.TimeStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFields))
            {
                query["UserFields"] = request.UserFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarmUpDuration))
            {
                query["WarmUpDuration"] = request.WarmUpDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudUpdateTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudUpdateTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudUpdateTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudUpdateTaskResponse
        /// </returns>
        public async Task<CloudUpdateTaskResponse> CloudUpdateTaskWithOptionsAsync(CloudUpdateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentGroup))
            {
                query["AgentGroup"] = request.AgentGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentTimeout))
            {
                query["AgentTimeout"] = request.AgentTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnswerRate))
            {
                query["AnswerRate"] = request.AnswerRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoComplete))
            {
                query["AutoComplete"] = request.AutoComplete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStart))
            {
                query["AutoStart"] = request.AutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartDay))
            {
                query["AutoStartDay"] = request.AutoStartDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStartTime))
            {
                query["AutoStartTime"] = request.AutoStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStop))
            {
                query["AutoStop"] = request.AutoStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopDay))
            {
                query["AutoStopDay"] = request.AutoStopDay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStopTime))
            {
                query["AutoStopTime"] = request.AutoStopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTaskType))
            {
                query["AutoTaskType"] = request.AutoTaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTriggerTimeStrategy))
            {
                query["AutoTriggerTimeStrategy"] = request.AutoTriggerTimeStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallLimitStrategy))
            {
                query["CallLimitStrategy"] = request.CallLimitStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallPriorityStrategy))
            {
                query["CallPriorityStrategy"] = request.CallPriorityStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallRouteStrategy))
            {
                query["CallRouteStrategy"] = request.CallRouteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStrategy))
            {
                query["CallStrategy"] = request.CallStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallVariables))
            {
                query["CallVariables"] = request.CallVariables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidProperty))
            {
                query["ClidProperty"] = request.ClidProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cnos))
            {
                query["Cnos"] = request.Cnos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["Concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidType))
            {
                query["CustomerClidType"] = request.CustomerClidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidWeight))
            {
                query["CustomerClidWeight"] = request.CustomerClidWeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidWeightFlag))
            {
                query["CustomerClidWeightFlag"] = request.CustomerClidWeightFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClids))
            {
                query["CustomerClids"] = request.CustomerClids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidsCategory))
            {
                query["CustomerClidsCategory"] = request.CustomerClidsCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerClidsGroup))
            {
                query["CustomerClidsGroup"] = request.CustomerClidsGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerMoh))
            {
                query["CustomerMoh"] = request.CustomerMoh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerTimeout))
            {
                query["CustomerTimeout"] = request.CustomerTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerVoice))
            {
                query["CustomerVoice"] = request.CustomerVoice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceEndFlag))
            {
                query["ForceEndFlag"] = request.ForceEndFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRewarm))
            {
                query["IsRewarm"] = request.IsRewarm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrId))
            {
                query["IvrId"] = request.IvrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrName))
            {
                query["IvrName"] = request.IvrName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWaitTime))
            {
                query["MaxWaitTime"] = request.MaxWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAvailableAgentCount))
            {
                query["MinAvailableAgentCount"] = request.MinAvailableAgentCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PredictAdjust))
            {
                query["PredictAdjust"] = request.PredictAdjust;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quotiety))
            {
                query["Quotiety"] = request.Quotiety;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategy))
            {
                query["RetryStrategy"] = request.RetryStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategyOnlyToday))
            {
                query["RetryStrategyOnlyToday"] = request.RetryStrategyOnlyToday;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryStrategyTimeType))
            {
                query["RetryStrategyTimeType"] = request.RetryStrategyTimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeStrategy))
            {
                query["TimeStrategy"] = request.TimeStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserFields))
            {
                query["UserFields"] = request.UserFields;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarmUpDuration))
            {
                query["WarmUpDuration"] = request.WarmUpDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wrapup))
            {
                query["Wrapup"] = request.Wrapup;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudUpdateTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudUpdateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudUpdateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudUpdateTaskResponse
        /// </returns>
        public CloudUpdateTaskResponse CloudUpdateTask(CloudUpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudUpdateTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudUpdateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudUpdateTaskResponse
        /// </returns>
        public async Task<CloudUpdateTaskResponse> CloudUpdateTaskAsync(CloudUpdateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudUpdateTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>webcall</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudWebcallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudWebcallResponse
        /// </returns>
        public CloudWebcallResponse CloudWebcallWithOptions(CloudWebcallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amd))
            {
                query["Amd"] = request.Amd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clid))
            {
                query["Clid"] = request.Clid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidAreaCode))
            {
                query["ClidAreaCode"] = request.ClidAreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidGroup))
            {
                query["ClidGroup"] = request.ClidGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidList))
            {
                query["ClidList"] = request.ClidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrnId))
            {
                query["CrnId"] = request.CrnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                query["Delay"] = request.Delay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirTime))
            {
                query["ExpirTime"] = request.ExpirTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrId))
            {
                query["IvrId"] = request.IvrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiTelDelay))
            {
                query["MultiTelDelay"] = request.MultiTelDelay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiTelPush))
            {
                query["MultiTelPush"] = request.MultiTelPush;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retry))
            {
                query["Retry"] = request.Retry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryInterval))
            {
                query["RetryInterval"] = request.RetryInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserField))
            {
                query["UserField"] = request.UserField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vid))
            {
                query["Vid"] = request.Vid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudWebcall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudWebcallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>webcall</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudWebcallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloudWebcallResponse
        /// </returns>
        public async Task<CloudWebcallResponse> CloudWebcallWithOptionsAsync(CloudWebcallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amd))
            {
                query["Amd"] = request.Amd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Clid))
            {
                query["Clid"] = request.Clid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidAreaCode))
            {
                query["ClidAreaCode"] = request.ClidAreaCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidGroup))
            {
                query["ClidGroup"] = request.ClidGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClidList))
            {
                query["ClidList"] = request.ClidList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrnId))
            {
                query["CrnId"] = request.CrnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                query["Delay"] = request.Delay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnterpriseId))
            {
                query["EnterpriseId"] = request.EnterpriseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirTime))
            {
                query["ExpirTime"] = request.ExpirTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IvrId))
            {
                query["IvrId"] = request.IvrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiTelDelay))
            {
                query["MultiTelDelay"] = request.MultiTelDelay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiTelPush))
            {
                query["MultiTelPush"] = request.MultiTelPush;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestUniqueId))
            {
                query["RequestUniqueId"] = request.RequestUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retry))
            {
                query["Retry"] = request.Retry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryInterval))
            {
                query["RetryInterval"] = request.RetryInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tel))
            {
                query["Tel"] = request.Tel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserField))
            {
                query["UserField"] = request.UserField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vid))
            {
                query["Vid"] = request.Vid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloudWebcall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloudWebcallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>webcall</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudWebcallRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudWebcallResponse
        /// </returns>
        public CloudWebcallResponse CloudWebcall(CloudWebcallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloudWebcallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>webcall</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloudWebcallRequest
        /// </param>
        /// 
        /// <returns>
        /// CloudWebcallResponse
        /// </returns>
        public async Task<CloudWebcallResponse> CloudWebcallAsync(CloudWebcallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloudWebcallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a service instance to create a text-to-speech (TTS) task, a voice notification task, or a voice verification code task for multiple called numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create up to 1,000 voice notifications for each task.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCallTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCallTaskResponse
        /// </returns>
        public CreateCallTaskResponse CreateCallTaskWithOptions(CreateCallTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FireTime))
            {
                query["FireTime"] = request.FireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["StopTime"] = request.StopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCallTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCallTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a service instance to create a text-to-speech (TTS) task, a voice notification task, or a voice verification code task for multiple called numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create up to 1,000 voice notifications for each task.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCallTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCallTaskResponse
        /// </returns>
        public async Task<CreateCallTaskResponse> CreateCallTaskWithOptionsAsync(CreateCallTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FireTime))
            {
                query["FireTime"] = request.FireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StopTime))
            {
                query["StopTime"] = request.StopTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCallTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCallTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a service instance to create a text-to-speech (TTS) task, a voice notification task, or a voice verification code task for multiple called numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create up to 1,000 voice notifications for each task.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCallTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCallTaskResponse
        /// </returns>
        public CreateCallTaskResponse CreateCallTask(CreateCallTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCallTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a service instance to create a text-to-speech (TTS) task, a voice notification task, or a voice verification code task for multiple called numbers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can create up to 1,000 voice notifications for each task.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCallTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCallTaskResponse
        /// </returns>
        public async Task<CreateCallTaskResponse> CreateCallTaskAsync(CreateCallTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCallTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an outbound robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate an outbound robocall task by using the robot communication scripts preset in the Voice Messaging Service console. In an intelligent speech interaction task, you can use the robot communication scripts preset in the Voice Messaging Service console, or invoke the callback function to return the response mode configured by the business party in each call.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRobotTaskResponse
        /// </returns>
        public CreateRobotTaskResponse CreateRobotTaskWithOptions(CreateRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                query["CorpName"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogId))
            {
                query["DialogId"] = request.DialogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSelfLine))
            {
                query["IsSelfLine"] = request.IsSelfLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberStatusIdent))
            {
                query["NumberStatusIdent"] = request.NumberStatusIdent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallInterval))
            {
                query["RecallInterval"] = request.RecallInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallStateCodes))
            {
                query["RecallStateCodes"] = request.RecallStateCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallTimes))
            {
                query["RecallTimes"] = request.RecallTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryType))
            {
                query["RetryType"] = request.RetryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRobotTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an outbound robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate an outbound robocall task by using the robot communication scripts preset in the Voice Messaging Service console. In an intelligent speech interaction task, you can use the robot communication scripts preset in the Voice Messaging Service console, or invoke the callback function to return the response mode configured by the business party in each call.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRobotTaskResponse
        /// </returns>
        public async Task<CreateRobotTaskResponse> CreateRobotTaskWithOptionsAsync(CreateRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                query["CorpName"] = request.CorpName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogId))
            {
                query["DialogId"] = request.DialogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSelfLine))
            {
                query["IsSelfLine"] = request.IsSelfLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberStatusIdent))
            {
                query["NumberStatusIdent"] = request.NumberStatusIdent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallInterval))
            {
                query["RecallInterval"] = request.RecallInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallStateCodes))
            {
                query["RecallStateCodes"] = request.RecallStateCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecallTimes))
            {
                query["RecallTimes"] = request.RecallTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetryType))
            {
                query["RetryType"] = request.RetryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRobotTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an outbound robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate an outbound robocall task by using the robot communication scripts preset in the Voice Messaging Service console. In an intelligent speech interaction task, you can use the robot communication scripts preset in the Voice Messaging Service console, or invoke the callback function to return the response mode configured by the business party in each call.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRobotTaskResponse
        /// </returns>
        public CreateRobotTaskResponse CreateRobotTask(CreateRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRobotTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an outbound robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate an outbound robocall task by using the robot communication scripts preset in the Voice Messaging Service console. In an intelligent speech interaction task, you can use the robot communication scripts preset in the Voice Messaging Service console, or invoke the callback function to return the response mode configured by the business party in each call.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRobotTaskResponse
        /// </returns>
        public async Task<CreateRobotTaskResponse> CreateRobotTaskAsync(CreateRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRobotTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Downgrades from a video call to a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DegradeVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DegradeVideoFileResponse
        /// </returns>
        public DegradeVideoFileResponse DegradeVideoFileWithOptions(DegradeVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DegradeVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DegradeVideoFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Downgrades from a video call to a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DegradeVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DegradeVideoFileResponse
        /// </returns>
        public async Task<DegradeVideoFileResponse> DegradeVideoFileWithOptionsAsync(DegradeVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DegradeVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DegradeVideoFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Downgrades from a video call to a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DegradeVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DegradeVideoFileResponse
        /// </returns>
        public DegradeVideoFileResponse DegradeVideoFile(DegradeVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DegradeVideoFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Downgrades from a video call to a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DegradeVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// DegradeVideoFileResponse
        /// </returns>
        public async Task<DegradeVideoFileResponse> DegradeVideoFileAsync(DegradeVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DegradeVideoFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to delete only tasks that are not started, that are completed, and that are terminated.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRobotTaskResponse
        /// </returns>
        public DeleteRobotTaskResponse DeleteRobotTaskWithOptions(DeleteRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRobotTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to delete only tasks that are not started, that are completed, and that are terminated.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRobotTaskResponse
        /// </returns>
        public async Task<DeleteRobotTaskResponse> DeleteRobotTaskWithOptionsAsync(DeleteRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRobotTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to delete only tasks that are not started, that are completed, and that are terminated.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRobotTaskResponse
        /// </returns>
        public DeleteRobotTaskResponse DeleteRobotTask(DeleteRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRobotTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to delete only tasks that are not started, that are completed, and that are terminated.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRobotTaskResponse
        /// </returns>
        public async Task<DeleteRobotTaskResponse> DeleteRobotTaskAsync(DeleteRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRobotTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a call task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecuteCallTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteCallTaskResponse
        /// </returns>
        public ExecuteCallTaskResponse ExecuteCallTaskWithOptions(ExecuteCallTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FireTime))
            {
                query["FireTime"] = request.FireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteCallTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteCallTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a call task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecuteCallTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteCallTaskResponse
        /// </returns>
        public async Task<ExecuteCallTaskResponse> ExecuteCallTaskWithOptionsAsync(ExecuteCallTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FireTime))
            {
                query["FireTime"] = request.FireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteCallTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteCallTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a call task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecuteCallTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteCallTaskResponse
        /// </returns>
        public ExecuteCallTaskResponse ExecuteCallTask(ExecuteCallTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteCallTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a call task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExecuteCallTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteCallTaskResponse
        /// </returns>
        public async Task<ExecuteCallTaskResponse> ExecuteCallTaskAsync(ExecuteCallTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteCallTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the call type during a call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallMediaTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallMediaTypeResponse
        /// </returns>
        public GetCallMediaTypeResponse GetCallMediaTypeWithOptions(GetCallMediaTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallMediaType",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallMediaTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the call type during a call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallMediaTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallMediaTypeResponse
        /// </returns>
        public async Task<GetCallMediaTypeResponse> GetCallMediaTypeWithOptionsAsync(GetCallMediaTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallMediaType",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallMediaTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the call type during a call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallMediaTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCallMediaTypeResponse
        /// </returns>
        public GetCallMediaTypeResponse GetCallMediaType(GetCallMediaTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCallMediaTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the call type during a call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallMediaTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCallMediaTypeResponse
        /// </returns>
        public async Task<GetCallMediaTypeResponse> GetCallMediaTypeAsync(GetCallMediaTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCallMediaTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetCallProgress</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallProgressResponse
        /// </returns>
        public GetCallProgressResponse GetCallProgressWithOptions(GetCallProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNum))
            {
                query["CalledNum"] = request.CalledNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallProgress",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetCallProgress</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallProgressResponse
        /// </returns>
        public async Task<GetCallProgressResponse> GetCallProgressWithOptionsAsync(GetCallProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNum))
            {
                query["CalledNum"] = request.CalledNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCallProgress",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetCallProgress</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCallProgressResponse
        /// </returns>
        public GetCallProgressResponse GetCallProgress(GetCallProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCallProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetCallProgress</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCallProgressResponse
        /// </returns>
        public async Task<GetCallProgressResponse> GetCallProgressAsync(GetCallProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCallProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the qualification ID based on the ID of a qualification application ticket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetHotlineQualificationByOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineQualificationByOrderResponse
        /// </returns>
        public GetHotlineQualificationByOrderResponse GetHotlineQualificationByOrderWithOptions(GetHotlineQualificationByOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineQualificationByOrder",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineQualificationByOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the qualification ID based on the ID of a qualification application ticket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetHotlineQualificationByOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineQualificationByOrderResponse
        /// </returns>
        public async Task<GetHotlineQualificationByOrderResponse> GetHotlineQualificationByOrderWithOptionsAsync(GetHotlineQualificationByOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHotlineQualificationByOrder",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHotlineQualificationByOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the qualification ID based on the ID of a qualification application ticket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetHotlineQualificationByOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineQualificationByOrderResponse
        /// </returns>
        public GetHotlineQualificationByOrderResponse GetHotlineQualificationByOrder(GetHotlineQualificationByOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHotlineQualificationByOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the qualification ID based on the ID of a qualification application ticket.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetHotlineQualificationByOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHotlineQualificationByOrderResponse
        /// </returns>
        public async Task<GetHotlineQualificationByOrderResponse> GetHotlineQualificationByOrderAsync(GetHotlineQualificationByOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHotlineQualificationByOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a temporary URL of a video or audio file. You can view the video or audio file immediately by using this temporary URL.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemporaryFileUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemporaryFileUrlResponse
        /// </returns>
        public GetTemporaryFileUrlResponse GetTemporaryFileUrlWithOptions(GetTemporaryFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemporaryFileUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemporaryFileUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a temporary URL of a video or audio file. You can view the video or audio file immediately by using this temporary URL.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemporaryFileUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTemporaryFileUrlResponse
        /// </returns>
        public async Task<GetTemporaryFileUrlResponse> GetTemporaryFileUrlWithOptionsAsync(GetTemporaryFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTemporaryFileUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTemporaryFileUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a temporary URL of a video or audio file. You can view the video or audio file immediately by using this temporary URL.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemporaryFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemporaryFileUrlResponse
        /// </returns>
        public GetTemporaryFileUrlResponse GetTemporaryFileUrl(GetTemporaryFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemporaryFileUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a temporary URL of a video or audio file. You can view the video or audio file immediately by using this temporary URL.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTemporaryFileUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTemporaryFileUrlResponse
        /// </returns>
        public async Task<GetTemporaryFileUrlResponse> GetTemporaryFileUrlAsync(GetTemporaryFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemporaryFileUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token for authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to five times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetTokenWithOptions(GetTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenType))
            {
                query["TokenType"] = request.TokenType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token for authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to five times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(GetTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenType))
            {
                query["TokenType"] = request.TokenType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetToken",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token for authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to five times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token for authentication.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to five times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTokenResponse
        /// </returns>
        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetVideoFieldUrl</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoFieldUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoFieldUrlResponse
        /// </returns>
        public GetVideoFieldUrlResponse GetVideoFieldUrlWithOptions(GetVideoFieldUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoFile))
            {
                query["VideoFile"] = request.VideoFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoFieldUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoFieldUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetVideoFieldUrl</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoFieldUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVideoFieldUrlResponse
        /// </returns>
        public async Task<GetVideoFieldUrlResponse> GetVideoFieldUrlWithOptionsAsync(GetVideoFieldUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoFile))
            {
                query["VideoFile"] = request.VideoFile;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVideoFieldUrl",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVideoFieldUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetVideoFieldUrl</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoFieldUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoFieldUrlResponse
        /// </returns>
        public GetVideoFieldUrlResponse GetVideoFieldUrl(GetVideoFieldUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVideoFieldUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetVideoFieldUrl</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVideoFieldUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVideoFieldUrlResponse
        /// </returns>
        public async Task<GetVideoFieldUrlResponse> GetVideoFieldUrlAsync(GetVideoFieldUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVideoFieldUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an interactive voice response (IVR) call to a specified number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Your enterprise qualification is approved. For more information, see <a href="https://help.aliyun.com/document_detail/149795.html">Submit enterprise qualifications</a>.</para>
        /// <list type="bullet">
        /// <item><description>Voice numbers are purchased. For more information, see <a href="https://help.aliyun.com/document_detail/149794.html">Purchase numbers</a>.</description></item>
        /// <item><description>When the subscriber answers the call, the subscriber hears a voice that instructs the subscriber to press a key as needed. If the <a href="https://help.aliyun.com/document_detail/112503.html">message receipt</a> feature is enabled, the Voice Messaging Service (VMS) platform returns the information about the key pressed by the subscriber to the business system. The key information includes the order confirmation, questionnaire survey, and satisfaction survey completed by the subscriber.</description></item>
        /// </list>
        /// <h2>QPS limits</h2>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// IvrCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IvrCallResponse
        /// </returns>
        public IvrCallResponse IvrCallWithOptions(IvrCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByeCode))
            {
                query["ByeCode"] = request.ByeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByeTtsParams))
            {
                query["ByeTtsParams"] = request.ByeTtsParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuKeyMap))
            {
                query["MenuKeyMap"] = request.MenuKeyMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCode))
            {
                query["StartCode"] = request.StartCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTtsParams))
            {
                query["StartTtsParams"] = request.StartTtsParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IvrCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IvrCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an interactive voice response (IVR) call to a specified number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Your enterprise qualification is approved. For more information, see <a href="https://help.aliyun.com/document_detail/149795.html">Submit enterprise qualifications</a>.</para>
        /// <list type="bullet">
        /// <item><description>Voice numbers are purchased. For more information, see <a href="https://help.aliyun.com/document_detail/149794.html">Purchase numbers</a>.</description></item>
        /// <item><description>When the subscriber answers the call, the subscriber hears a voice that instructs the subscriber to press a key as needed. If the <a href="https://help.aliyun.com/document_detail/112503.html">message receipt</a> feature is enabled, the Voice Messaging Service (VMS) platform returns the information about the key pressed by the subscriber to the business system. The key information includes the order confirmation, questionnaire survey, and satisfaction survey completed by the subscriber.</description></item>
        /// </list>
        /// <h2>QPS limits</h2>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// IvrCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IvrCallResponse
        /// </returns>
        public async Task<IvrCallResponse> IvrCallWithOptionsAsync(IvrCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByeCode))
            {
                query["ByeCode"] = request.ByeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ByeTtsParams))
            {
                query["ByeTtsParams"] = request.ByeTtsParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MenuKeyMap))
            {
                query["MenuKeyMap"] = request.MenuKeyMap;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartCode))
            {
                query["StartCode"] = request.StartCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTtsParams))
            {
                query["StartTtsParams"] = request.StartTtsParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IvrCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IvrCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an interactive voice response (IVR) call to a specified number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Your enterprise qualification is approved. For more information, see <a href="https://help.aliyun.com/document_detail/149795.html">Submit enterprise qualifications</a>.</para>
        /// <list type="bullet">
        /// <item><description>Voice numbers are purchased. For more information, see <a href="https://help.aliyun.com/document_detail/149794.html">Purchase numbers</a>.</description></item>
        /// <item><description>When the subscriber answers the call, the subscriber hears a voice that instructs the subscriber to press a key as needed. If the <a href="https://help.aliyun.com/document_detail/112503.html">message receipt</a> feature is enabled, the Voice Messaging Service (VMS) platform returns the information about the key pressed by the subscriber to the business system. The key information includes the order confirmation, questionnaire survey, and satisfaction survey completed by the subscriber.</description></item>
        /// </list>
        /// <h2>QPS limits</h2>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// IvrCallRequest
        /// </param>
        /// 
        /// <returns>
        /// IvrCallResponse
        /// </returns>
        public IvrCallResponse IvrCall(IvrCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IvrCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an interactive voice response (IVR) call to a specified number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Your enterprise qualification is approved. For more information, see <a href="https://help.aliyun.com/document_detail/149795.html">Submit enterprise qualifications</a>.</para>
        /// <list type="bullet">
        /// <item><description>Voice numbers are purchased. For more information, see <a href="https://help.aliyun.com/document_detail/149794.html">Purchase numbers</a>.</description></item>
        /// <item><description>When the subscriber answers the call, the subscriber hears a voice that instructs the subscriber to press a key as needed. If the <a href="https://help.aliyun.com/document_detail/112503.html">message receipt</a> feature is enabled, the Voice Messaging Service (VMS) platform returns the information about the key pressed by the subscriber to the business system. The key information includes the order confirmation, questionnaire survey, and satisfaction survey completed by the subscriber.</description></item>
        /// </list>
        /// <h2>QPS limits</h2>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// IvrCallRequest
        /// </param>
        /// 
        /// <returns>
        /// IvrCallResponse
        /// </returns>
        public async Task<IvrCallResponse> IvrCallAsync(IvrCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IvrCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a voice call task after the task is created, including the task ID, task status, and templates used by the task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCallTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCallTaskResponse
        /// </returns>
        public ListCallTaskResponse ListCallTaskWithOptions(ListCallTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCallTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCallTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a voice call task after the task is created, including the task ID, task status, and templates used by the task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCallTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCallTaskResponse
        /// </returns>
        public async Task<ListCallTaskResponse> ListCallTaskWithOptionsAsync(ListCallTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCallTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCallTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a voice call task after the task is created, including the task ID, task status, and templates used by the task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCallTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCallTaskResponse
        /// </returns>
        public ListCallTaskResponse ListCallTask(ListCallTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCallTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a voice call task after the task is created, including the task ID, task status, and templates used by the task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCallTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCallTaskResponse
        /// </returns>
        public async Task<ListCallTaskResponse> ListCallTaskAsync(ListCallTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCallTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of call tasks based on task IDs after call tasks are complete.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCallTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCallTaskDetailResponse
        /// </returns>
        public ListCallTaskDetailResponse ListCallTaskDetailWithOptions(ListCallTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNum))
            {
                query["CalledNum"] = request.CalledNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCallTaskDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCallTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of call tasks based on task IDs after call tasks are complete.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCallTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCallTaskDetailResponse
        /// </returns>
        public async Task<ListCallTaskDetailResponse> ListCallTaskDetailWithOptionsAsync(ListCallTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNum))
            {
                query["CalledNum"] = request.CalledNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCallTaskDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCallTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of call tasks based on task IDs after call tasks are complete.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCallTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCallTaskDetailResponse
        /// </returns>
        public ListCallTaskDetailResponse ListCallTaskDetail(ListCallTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCallTaskDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of call tasks based on task IDs after call tasks are complete.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListCallTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCallTaskDetailResponse
        /// </returns>
        public async Task<ListCallTaskDetailResponse> ListCallTaskDetailAsync(ListCallTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCallTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registration information about a China 400 number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListHotlineTransferRegisterFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineTransferRegisterFileResponse
        /// </returns>
        public ListHotlineTransferRegisterFileResponse ListHotlineTransferRegisterFileWithOptions(ListHotlineTransferRegisterFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                query["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotlineTransferRegisterFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotlineTransferRegisterFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registration information about a China 400 number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListHotlineTransferRegisterFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineTransferRegisterFileResponse
        /// </returns>
        public async Task<ListHotlineTransferRegisterFileResponse> ListHotlineTransferRegisterFileWithOptionsAsync(ListHotlineTransferRegisterFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                query["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHotlineTransferRegisterFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHotlineTransferRegisterFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registration information about a China 400 number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListHotlineTransferRegisterFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineTransferRegisterFileResponse
        /// </returns>
        public ListHotlineTransferRegisterFileResponse ListHotlineTransferRegisterFile(ListHotlineTransferRegisterFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotlineTransferRegisterFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registration information about a China 400 number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListHotlineTransferRegisterFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHotlineTransferRegisterFileResponse
        /// </returns>
        public async Task<ListHotlineTransferRegisterFileResponse> ListHotlineTransferRegisterFileAsync(ListHotlineTransferRegisterFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotlineTransferRegisterFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询服务实例列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListServiceInstanceForPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceInstanceForPageResponse
        /// </returns>
        public ListServiceInstanceForPageResponse ListServiceInstanceForPageWithOptions(ListServiceInstanceForPageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServiceInstanceForPageShrinkRequest request = new ListServiceInstanceForPageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Pager))
            {
                request.PagerShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Pager, "Pager", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PagerShrink))
            {
                query["Pager"] = request.PagerShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationNumber))
            {
                query["RelationNumber"] = request.RelationNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageId))
            {
                query["UsageId"] = request.UsageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstanceForPage",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstanceForPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询服务实例列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListServiceInstanceForPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceInstanceForPageResponse
        /// </returns>
        public async Task<ListServiceInstanceForPageResponse> ListServiceInstanceForPageWithOptionsAsync(ListServiceInstanceForPageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServiceInstanceForPageShrinkRequest request = new ListServiceInstanceForPageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Pager))
            {
                request.PagerShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Pager, "Pager", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PagerShrink))
            {
                query["Pager"] = request.PagerShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationNumber))
            {
                query["RelationNumber"] = request.RelationNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageId))
            {
                query["UsageId"] = request.UsageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstanceForPage",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstanceForPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询服务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceInstanceForPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceInstanceForPageResponse
        /// </returns>
        public ListServiceInstanceForPageResponse ListServiceInstanceForPage(ListServiceInstanceForPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceInstanceForPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分页查询服务实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceInstanceForPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceInstanceForPageResponse
        /// </returns>
        public async Task<ListServiceInstanceForPageResponse> ListServiceInstanceForPageAsync(ListServiceInstanceForPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceInstanceForPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses video playback when a video file is played back during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PauseVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseVideoFileResponse
        /// </returns>
        public PauseVideoFileResponse PauseVideoFileWithOptions(PauseVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseVideoFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses video playback when a video file is played back during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PauseVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseVideoFileResponse
        /// </returns>
        public async Task<PauseVideoFileResponse> PauseVideoFileWithOptionsAsync(PauseVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseVideoFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses video playback when a video file is played back during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PauseVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseVideoFileResponse
        /// </returns>
        public PauseVideoFileResponse PauseVideoFile(PauseVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PauseVideoFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses video playback when a video file is played back during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PauseVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseVideoFileResponse
        /// </returns>
        public async Task<PauseVideoFileResponse> PauseVideoFileAsync(PauseVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PauseVideoFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Plays back a video file during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlayVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlayVideoFileResponse
        /// </returns>
        public PlayVideoFileResponse PlayVideoFileWithOptions(PlayVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyPhone))
            {
                query["OnlyPhone"] = request.OnlyPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlayVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlayVideoFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Plays back a video file during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlayVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PlayVideoFileResponse
        /// </returns>
        public async Task<PlayVideoFileResponse> PlayVideoFileWithOptionsAsync(PlayVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyPhone))
            {
                query["OnlyPhone"] = request.OnlyPhone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoId))
            {
                query["VideoId"] = request.VideoId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PlayVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PlayVideoFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Plays back a video file during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlayVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// PlayVideoFileResponse
        /// </returns>
        public PlayVideoFileResponse PlayVideoFile(PlayVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PlayVideoFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Plays back a video file during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PlayVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// PlayVideoFileResponse
        /// </returns>
        public async Task<PlayVideoFileResponse> PlayVideoFileAsync(PlayVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PlayVideoFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>QueryCallDetailByCallId is a common query operation. You can call this operation to query the details of a voice notification, voice verification code, interactive voice response (IVR), intelligent inbound voice call, intelligent outbound voice call, or intelligent robocall.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallDetailByCallIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallDetailByCallIdResponse
        /// </returns>
        public QueryCallDetailByCallIdResponse QueryCallDetailByCallIdWithOptions(QueryCallDetailByCallIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdId))
            {
                query["ProdId"] = request.ProdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDate))
            {
                query["QueryDate"] = request.QueryDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallDetailByCallId",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallDetailByCallIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>QueryCallDetailByCallId is a common query operation. You can call this operation to query the details of a voice notification, voice verification code, interactive voice response (IVR), intelligent inbound voice call, intelligent outbound voice call, or intelligent robocall.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallDetailByCallIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallDetailByCallIdResponse
        /// </returns>
        public async Task<QueryCallDetailByCallIdResponse> QueryCallDetailByCallIdWithOptionsAsync(QueryCallDetailByCallIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdId))
            {
                query["ProdId"] = request.ProdId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDate))
            {
                query["QueryDate"] = request.QueryDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallDetailByCallId",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallDetailByCallIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>QueryCallDetailByCallId is a common query operation. You can call this operation to query the details of a voice notification, voice verification code, interactive voice response (IVR), intelligent inbound voice call, intelligent outbound voice call, or intelligent robocall.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallDetailByCallIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallDetailByCallIdResponse
        /// </returns>
        public QueryCallDetailByCallIdResponse QueryCallDetailByCallId(QueryCallDetailByCallIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallDetailByCallIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>QueryCallDetailByCallId is a common query operation. You can call this operation to query the details of a voice notification, voice verification code, interactive voice response (IVR), intelligent inbound voice call, intelligent outbound voice call, or intelligent robocall.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallDetailByCallIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallDetailByCallIdResponse
        /// </returns>
        public async Task<QueryCallDetailByCallIdResponse> QueryCallDetailByCallIdAsync(QueryCallDetailByCallIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallDetailByCallIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the call details of an outbound robocall task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallDetailByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallDetailByTaskIdResponse
        /// </returns>
        public QueryCallDetailByTaskIdResponse QueryCallDetailByTaskIdWithOptions(QueryCallDetailByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                query["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDate))
            {
                query["QueryDate"] = request.QueryDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallDetailByTaskId",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallDetailByTaskIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the call details of an outbound robocall task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallDetailByTaskIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallDetailByTaskIdResponse
        /// </returns>
        public async Task<QueryCallDetailByTaskIdResponse> QueryCallDetailByTaskIdWithOptionsAsync(QueryCallDetailByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                query["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDate))
            {
                query["QueryDate"] = request.QueryDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallDetailByTaskId",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallDetailByTaskIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the call details of an outbound robocall task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallDetailByTaskIdResponse
        /// </returns>
        public QueryCallDetailByTaskIdResponse QueryCallDetailByTaskId(QueryCallDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallDetailByTaskIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the call details of an outbound robocall task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallDetailByTaskIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallDetailByTaskIdResponse
        /// </returns>
        public async Task<QueryCallDetailByTaskIdResponse> QueryCallDetailByTaskIdAsync(QueryCallDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallDetailByTaskIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of the phone number used to transfer a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallInPoolTransferConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallInPoolTransferConfigResponse
        /// </returns>
        public QueryCallInPoolTransferConfigResponse QueryCallInPoolTransferConfigWithOptions(QueryCallInPoolTransferConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallInPoolTransferConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallInPoolTransferConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of the phone number used to transfer a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallInPoolTransferConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallInPoolTransferConfigResponse
        /// </returns>
        public async Task<QueryCallInPoolTransferConfigResponse> QueryCallInPoolTransferConfigWithOptionsAsync(QueryCallInPoolTransferConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallInPoolTransferConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallInPoolTransferConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of the phone number used to transfer a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallInPoolTransferConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallInPoolTransferConfigResponse
        /// </returns>
        public QueryCallInPoolTransferConfigResponse QueryCallInPoolTransferConfig(QueryCallInPoolTransferConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallInPoolTransferConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configuration of the phone number used to transfer a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallInPoolTransferConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallInPoolTransferConfigResponse
        /// </returns>
        public async Task<QueryCallInPoolTransferConfigResponse> QueryCallInPoolTransferConfigAsync(QueryCallInPoolTransferConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallInPoolTransferConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries call transfer records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallInTransferRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallInTransferRecordResponse
        /// </returns>
        public QueryCallInTransferRecordResponse QueryCallInTransferRecordWithOptions(QueryCallInTransferRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallInCaller))
            {
                query["CallInCaller"] = request.CallInCaller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDate))
            {
                query["QueryDate"] = request.QueryDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallInTransferRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallInTransferRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries call transfer records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallInTransferRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallInTransferRecordResponse
        /// </returns>
        public async Task<QueryCallInTransferRecordResponse> QueryCallInTransferRecordWithOptionsAsync(QueryCallInTransferRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallInCaller))
            {
                query["CallInCaller"] = request.CallInCaller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDate))
            {
                query["QueryDate"] = request.QueryDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallInTransferRecord",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallInTransferRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries call transfer records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallInTransferRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallInTransferRecordResponse
        /// </returns>
        public QueryCallInTransferRecordResponse QueryCallInTransferRecord(QueryCallInTransferRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallInTransferRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries call transfer records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryCallInTransferRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallInTransferRecordResponse
        /// </returns>
        public async Task<QueryCallInTransferRecordResponse> QueryCallInTransferRecordAsync(QueryCallInTransferRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallInTransferRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of robots to obtain their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRobotInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotInfoListResponse
        /// </returns>
        public QueryRobotInfoListResponse QueryRobotInfoListWithOptions(QueryRobotInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotInfoList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotInfoListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of robots to obtain their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRobotInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotInfoListResponse
        /// </returns>
        public async Task<QueryRobotInfoListResponse> QueryRobotInfoListWithOptionsAsync(QueryRobotInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotInfoList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotInfoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of robots to obtain their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRobotInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotInfoListResponse
        /// </returns>
        public QueryRobotInfoListResponse QueryRobotInfoList(QueryRobotInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotInfoListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of robots to obtain their details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRobotInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotInfoListResponse
        /// </returns>
        public async Task<QueryRobotInfoListResponse> QueryRobotInfoListAsync(QueryRobotInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotInfoListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the call details of a called number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskCallDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskCallDetailResponse
        /// </returns>
        public QueryRobotTaskCallDetailResponse QueryRobotTaskCallDetailWithOptions(QueryRobotTaskCallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                query["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDate))
            {
                query["QueryDate"] = request.QueryDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotTaskCallDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotTaskCallDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the call details of a called number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskCallDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskCallDetailResponse
        /// </returns>
        public async Task<QueryRobotTaskCallDetailResponse> QueryRobotTaskCallDetailWithOptionsAsync(QueryRobotTaskCallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                query["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDate))
            {
                query["QueryDate"] = request.QueryDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotTaskCallDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotTaskCallDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the call details of a called number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskCallDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskCallDetailResponse
        /// </returns>
        public QueryRobotTaskCallDetailResponse QueryRobotTaskCallDetail(QueryRobotTaskCallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotTaskCallDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the call details of a called number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskCallDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskCallDetailResponse
        /// </returns>
        public async Task<QueryRobotTaskCallDetailResponse> QueryRobotTaskCallDetailAsync(QueryRobotTaskCallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotTaskCallDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskCallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskCallListResponse
        /// </returns>
        public QueryRobotTaskCallListResponse QueryRobotTaskCallListWithOptions(QueryRobotTaskCallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallResult))
            {
                query["CallResult"] = request.CallResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Called))
            {
                query["Called"] = request.Called;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogCountFrom))
            {
                query["DialogCountFrom"] = request.DialogCountFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogCountTo))
            {
                query["DialogCountTo"] = request.DialogCountTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationFrom))
            {
                query["DurationFrom"] = request.DurationFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationTo))
            {
                query["DurationTo"] = request.DurationTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HangupDirection))
            {
                query["HangupDirection"] = request.HangupDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotTaskCallList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotTaskCallListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskCallListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskCallListResponse
        /// </returns>
        public async Task<QueryRobotTaskCallListResponse> QueryRobotTaskCallListWithOptionsAsync(QueryRobotTaskCallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallResult))
            {
                query["CallResult"] = request.CallResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Called))
            {
                query["Called"] = request.Called;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogCountFrom))
            {
                query["DialogCountFrom"] = request.DialogCountFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DialogCountTo))
            {
                query["DialogCountTo"] = request.DialogCountTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationFrom))
            {
                query["DurationFrom"] = request.DurationFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationTo))
            {
                query["DurationTo"] = request.DurationTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HangupDirection))
            {
                query["HangupDirection"] = request.HangupDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotTaskCallList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotTaskCallListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskCallListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskCallListResponse
        /// </returns>
        public QueryRobotTaskCallListResponse QueryRobotTaskCallList(QueryRobotTaskCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotTaskCallListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskCallListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskCallListResponse
        /// </returns>
        public async Task<QueryRobotTaskCallListResponse> QueryRobotTaskCallListAsync(QueryRobotTaskCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotTaskCallListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskDetailResponse
        /// </returns>
        public QueryRobotTaskDetailResponse QueryRobotTaskDetailWithOptions(QueryRobotTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotTaskDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskDetailResponse
        /// </returns>
        public async Task<QueryRobotTaskDetailResponse> QueryRobotTaskDetailWithOptionsAsync(QueryRobotTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotTaskDetail",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskDetailResponse
        /// </returns>
        public QueryRobotTaskDetailResponse QueryRobotTaskDetail(QueryRobotTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotTaskDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskDetailResponse
        /// </returns>
        public async Task<QueryRobotTaskDetailResponse> QueryRobotTaskDetailAsync(QueryRobotTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all robocall tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskListResponse
        /// </returns>
        public QueryRobotTaskListResponse QueryRobotTaskListWithOptions(QueryRobotTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotTaskList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotTaskListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all robocall tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskListResponse
        /// </returns>
        public async Task<QueryRobotTaskListResponse> QueryRobotTaskListWithOptionsAsync(QueryRobotTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                query["TaskName"] = request.TaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotTaskList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all robocall tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskListResponse
        /// </returns>
        public QueryRobotTaskListResponse QueryRobotTaskList(QueryRobotTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotTaskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all robocall tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotTaskListResponse
        /// </returns>
        public async Task<QueryRobotTaskListResponse> QueryRobotTaskListAsync(QueryRobotTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotTaskListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of robot communication scripts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotv2AllListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotv2AllListResponse
        /// </returns>
        public QueryRobotv2AllListResponse QueryRobotv2AllListWithOptions(QueryRobotv2AllListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotv2AllList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotv2AllListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of robot communication scripts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotv2AllListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotv2AllListResponse
        /// </returns>
        public async Task<QueryRobotv2AllListResponse> QueryRobotv2AllListWithOptionsAsync(QueryRobotv2AllListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRobotv2AllList",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRobotv2AllListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of robot communication scripts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotv2AllListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotv2AllListResponse
        /// </returns>
        public QueryRobotv2AllListResponse QueryRobotv2AllList(QueryRobotv2AllListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotv2AllListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of robot communication scripts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRobotv2AllListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRobotv2AllListResponse
        /// </returns>
        public async Task<QueryRobotv2AllListResponse> QueryRobotv2AllListAsync(QueryRobotv2AllListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotv2AllListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the video playback progress after you play a video file during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVideoPlayProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVideoPlayProgressResponse
        /// </returns>
        public QueryVideoPlayProgressResponse QueryVideoPlayProgressWithOptions(QueryVideoPlayProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVideoPlayProgress",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVideoPlayProgressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the video playback progress after you play a video file during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVideoPlayProgressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVideoPlayProgressResponse
        /// </returns>
        public async Task<QueryVideoPlayProgressResponse> QueryVideoPlayProgressWithOptionsAsync(QueryVideoPlayProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVideoPlayProgress",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVideoPlayProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the video playback progress after you play a video file during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVideoPlayProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVideoPlayProgressResponse
        /// </returns>
        public QueryVideoPlayProgressResponse QueryVideoPlayProgress(QueryVideoPlayProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVideoPlayProgressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the video playback progress after you play a video file during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVideoPlayProgressRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVideoPlayProgressResponse
        /// </returns>
        public async Task<QueryVideoPlayProgressResponse> QueryVideoPlayProgressAsync(QueryVideoPlayProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVideoPlayProgressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists real numbers bound to service instances. The returned data includes the binding time, the number activation time, and the number of real numbers bound to a service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryVirtualNumberRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVirtualNumberRelationResponse
        /// </returns>
        public QueryVirtualNumberRelationResponse QueryVirtualNumberRelationWithOptions(QueryVirtualNumberRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNum))
            {
                query["PhoneNum"] = request.PhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNameCity))
            {
                query["RegionNameCity"] = request.RegionNameCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedNum))
            {
                query["RelatedNum"] = request.RelatedNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                query["RouteType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecId))
            {
                query["SpecId"] = request.SpecId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVirtualNumberRelation",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVirtualNumberRelationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists real numbers bound to service instances. The returned data includes the binding time, the number activation time, and the number of real numbers bound to a service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryVirtualNumberRelationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVirtualNumberRelationResponse
        /// </returns>
        public async Task<QueryVirtualNumberRelationResponse> QueryVirtualNumberRelationWithOptionsAsync(QueryVirtualNumberRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNum))
            {
                query["PhoneNum"] = request.PhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProdCode))
            {
                query["ProdCode"] = request.ProdCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNameCity))
            {
                query["RegionNameCity"] = request.RegionNameCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedNum))
            {
                query["RelatedNum"] = request.RelatedNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteType))
            {
                query["RouteType"] = request.RouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecId))
            {
                query["SpecId"] = request.SpecId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVirtualNumberRelation",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVirtualNumberRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists real numbers bound to service instances. The returned data includes the binding time, the number activation time, and the number of real numbers bound to a service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryVirtualNumberRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVirtualNumberRelationResponse
        /// </returns>
        public QueryVirtualNumberRelationResponse QueryVirtualNumberRelation(QueryVirtualNumberRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVirtualNumberRelationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists real numbers bound to service instances. The returned data includes the binding time, the number activation time, and the number of real numbers bound to a service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryVirtualNumberRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVirtualNumberRelationResponse
        /// </returns>
        public async Task<QueryVirtualNumberRelationResponse> QueryVirtualNumberRelationAsync(QueryVirtualNumberRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVirtualNumberRelationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询真实号接通率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVmsRealNumberCallConnectionRateInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVmsRealNumberCallConnectionRateInfoResponse
        /// </returns>
        public QueryVmsRealNumberCallConnectionRateInfoResponse QueryVmsRealNumberCallConnectionRateInfoWithOptions(QueryVmsRealNumberCallConnectionRateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNumber))
            {
                query["RealNumber"] = request.RealNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePeriod))
            {
                query["TimePeriod"] = request.TimePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNumber))
            {
                query["VirtualNumber"] = request.VirtualNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVmsRealNumberCallConnectionRateInfo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVmsRealNumberCallConnectionRateInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询真实号接通率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVmsRealNumberCallConnectionRateInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVmsRealNumberCallConnectionRateInfoResponse
        /// </returns>
        public async Task<QueryVmsRealNumberCallConnectionRateInfoResponse> QueryVmsRealNumberCallConnectionRateInfoWithOptionsAsync(QueryVmsRealNumberCallConnectionRateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNumber))
            {
                query["RealNumber"] = request.RealNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePeriod))
            {
                query["TimePeriod"] = request.TimePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNumber))
            {
                query["VirtualNumber"] = request.VirtualNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVmsRealNumberCallConnectionRateInfo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVmsRealNumberCallConnectionRateInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询真实号接通率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVmsRealNumberCallConnectionRateInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVmsRealNumberCallConnectionRateInfoResponse
        /// </returns>
        public QueryVmsRealNumberCallConnectionRateInfoResponse QueryVmsRealNumberCallConnectionRateInfo(QueryVmsRealNumberCallConnectionRateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVmsRealNumberCallConnectionRateInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询真实号接通率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVmsRealNumberCallConnectionRateInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVmsRealNumberCallConnectionRateInfoResponse
        /// </returns>
        public async Task<QueryVmsRealNumberCallConnectionRateInfoResponse> QueryVmsRealNumberCallConnectionRateInfoAsync(QueryVmsRealNumberCallConnectionRateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVmsRealNumberCallConnectionRateInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询虚拟号码与真实号码绑定关系列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVmsVirtualNumberRelationByPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVmsVirtualNumberRelationByPageResponse
        /// </returns>
        public QueryVmsVirtualNumberRelationByPageResponse QueryVmsVirtualNumberRelationByPageWithOptions(QueryVmsVirtualNumberRelationByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberCity))
            {
                query["NumberCity"] = request.NumberCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberProvince))
            {
                query["NumberProvince"] = request.NumberProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNumber))
            {
                query["RealNumber"] = request.RealNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNumber))
            {
                query["VirtualNumber"] = request.VirtualNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVmsVirtualNumberRelationByPage",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVmsVirtualNumberRelationByPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询虚拟号码与真实号码绑定关系列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVmsVirtualNumberRelationByPageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVmsVirtualNumberRelationByPageResponse
        /// </returns>
        public async Task<QueryVmsVirtualNumberRelationByPageResponse> QueryVmsVirtualNumberRelationByPageWithOptionsAsync(QueryVmsVirtualNumberRelationByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberCity))
            {
                query["NumberCity"] = request.NumberCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberProvince))
            {
                query["NumberProvince"] = request.NumberProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNumber))
            {
                query["RealNumber"] = request.RealNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNumber))
            {
                query["VirtualNumber"] = request.VirtualNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVmsVirtualNumberRelationByPage",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVmsVirtualNumberRelationByPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询虚拟号码与真实号码绑定关系列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVmsVirtualNumberRelationByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVmsVirtualNumberRelationByPageResponse
        /// </returns>
        public QueryVmsVirtualNumberRelationByPageResponse QueryVmsVirtualNumberRelationByPage(QueryVmsVirtualNumberRelationByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVmsVirtualNumberRelationByPageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询虚拟号码与真实号码绑定关系列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVmsVirtualNumberRelationByPageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVmsVirtualNumberRelationByPageResponse
        /// </returns>
        public async Task<QueryVmsVirtualNumberRelationByPageResponse> QueryVmsVirtualNumberRelationByPageAsync(QueryVmsVirtualNumberRelationByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVmsVirtualNumberRelationByPageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review state of a voice file.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVoiceFileAuditInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVoiceFileAuditInfoResponse
        /// </returns>
        public QueryVoiceFileAuditInfoResponse QueryVoiceFileAuditInfoWithOptions(QueryVoiceFileAuditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCodes))
            {
                query["VoiceCodes"] = request.VoiceCodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVoiceFileAuditInfo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVoiceFileAuditInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review state of a voice file.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVoiceFileAuditInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVoiceFileAuditInfoResponse
        /// </returns>
        public async Task<QueryVoiceFileAuditInfoResponse> QueryVoiceFileAuditInfoWithOptionsAsync(QueryVoiceFileAuditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCodes))
            {
                query["VoiceCodes"] = request.VoiceCodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryVoiceFileAuditInfo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVoiceFileAuditInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review state of a voice file.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVoiceFileAuditInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVoiceFileAuditInfoResponse
        /// </returns>
        public QueryVoiceFileAuditInfoResponse QueryVoiceFileAuditInfo(QueryVoiceFileAuditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVoiceFileAuditInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the review state of a voice file.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVoiceFileAuditInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVoiceFileAuditInfoResponse
        /// </returns>
        public async Task<QueryVoiceFileAuditInfoResponse> QueryVoiceFileAuditInfoAsync(QueryVoiceFileAuditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVoiceFileAuditInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes the inbound call that is transferred by using a China 400 number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverCallInConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoverCallInConfigResponse
        /// </returns>
        public RecoverCallInConfigResponse RecoverCallInConfigWithOptions(RecoverCallInConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverCallInConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverCallInConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes the inbound call that is transferred by using a China 400 number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverCallInConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoverCallInConfigResponse
        /// </returns>
        public async Task<RecoverCallInConfigResponse> RecoverCallInConfigWithOptionsAsync(RecoverCallInConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverCallInConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverCallInConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes the inbound call that is transferred by using a China 400 number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverCallInConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoverCallInConfigResponse
        /// </returns>
        public RecoverCallInConfigResponse RecoverCallInConfig(RecoverCallInConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecoverCallInConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes the inbound call that is transferred by using a China 400 number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverCallInConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoverCallInConfigResponse
        /// </returns>
        public async Task<RecoverCallInConfigResponse> RecoverCallInConfigAsync(RecoverCallInConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecoverCallInConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes video playback after you pause video playback during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeVideoFileResponse
        /// </returns>
        public ResumeVideoFileResponse ResumeVideoFileWithOptions(ResumeVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeVideoFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes video playback after you pause video playback during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeVideoFileResponse
        /// </returns>
        public async Task<ResumeVideoFileResponse> ResumeVideoFileWithOptionsAsync(ResumeVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeVideoFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes video playback after you pause video playback during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeVideoFileResponse
        /// </returns>
        public ResumeVideoFileResponse ResumeVideoFile(ResumeVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeVideoFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resumes video playback after you pause video playback during a voice call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeVideoFileResponse
        /// </returns>
        public async Task<ResumeVideoFileResponse> ResumeVideoFileAsync(ResumeVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeVideoFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SeekVideoFile</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SeekVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SeekVideoFileResponse
        /// </returns>
        public SeekVideoFileResponse SeekVideoFileWithOptions(SeekVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeekTimes))
            {
                query["SeekTimes"] = request.SeekTimes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SeekVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SeekVideoFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SeekVideoFile</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SeekVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SeekVideoFileResponse
        /// </returns>
        public async Task<SeekVideoFileResponse> SeekVideoFileWithOptionsAsync(SeekVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeekTimes))
            {
                query["SeekTimes"] = request.SeekTimes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SeekVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SeekVideoFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SeekVideoFile</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SeekVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// SeekVideoFileResponse
        /// </returns>
        public SeekVideoFileResponse SeekVideoFile(SeekVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SeekVideoFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>SeekVideoFile</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SeekVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// SeekVideoFileResponse
        /// </returns>
        public async Task<SeekVideoFileResponse> SeekVideoFileAsync(SeekVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SeekVideoFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendVerificationResponse
        /// </returns>
        public SendVerificationResponse SendVerificationWithOptions(SendVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendVerification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendVerificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendVerificationResponse
        /// </returns>
        public async Task<SendVerificationResponse> SendVerificationWithOptionsAsync(SendVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyType))
            {
                query["VerifyType"] = request.VerifyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendVerification",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SendVerificationResponse
        /// </returns>
        public SendVerificationResponse SendVerification(SendVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends an SMS verification code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SendVerificationResponse
        /// </returns>
        public async Task<SendVerificationResponse> SendVerificationAsync(SendVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the phone numbers for transferring a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetTransferCalleePoolConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTransferCalleePoolConfigResponse
        /// </returns>
        public SetTransferCalleePoolConfigResponse SetTransferCalleePoolConfigWithOptions(SetTransferCalleePoolConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledRouteMode))
            {
                query["CalledRouteMode"] = request.CalledRouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Details))
            {
                query["Details"] = request.Details;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTransferCalleePoolConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTransferCalleePoolConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the phone numbers for transferring a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetTransferCalleePoolConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetTransferCalleePoolConfigResponse
        /// </returns>
        public async Task<SetTransferCalleePoolConfigResponse> SetTransferCalleePoolConfigWithOptionsAsync(SetTransferCalleePoolConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledRouteMode))
            {
                query["CalledRouteMode"] = request.CalledRouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Details))
            {
                query["Details"] = request.Details;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTransferCalleePoolConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTransferCalleePoolConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the phone numbers for transferring a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetTransferCalleePoolConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTransferCalleePoolConfigResponse
        /// </returns>
        public SetTransferCalleePoolConfigResponse SetTransferCalleePoolConfig(SetTransferCalleePoolConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTransferCalleePoolConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets the phone numbers for transferring a call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SetTransferCalleePoolConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// SetTransferCalleePoolConfigResponse
        /// </returns>
        public async Task<SetTransferCalleePoolConfigResponse> SetTransferCalleePoolConfigAsync(SetTransferCalleePoolConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTransferCalleePoolConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a voice verification code or a voice notification with variables to a specified phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Due to business adjustments, the updates of the voice notification and voice verification code services have been stopped in regions outside the Chinese mainland and the services have been discontinued since March 2022. Only qualified customers can continue using the voice notification and voice verification code services.</para>
        /// <list type="bullet">
        /// <item><description>For more information about voice plans or voice service billing, see <a href="https://help.aliyun.com/document_detail/150083.html">Pricing of VMS on China site (aliyun.com)</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleCallByTtsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByTtsResponse
        /// </returns>
        public SingleCallByTtsResponse SingleCallByTtsWithOptions(SingleCallByTtsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsCode))
            {
                query["TtsCode"] = request.TtsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParam))
            {
                query["TtsParam"] = request.TtsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleCallByTts",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleCallByTtsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a voice verification code or a voice notification with variables to a specified phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Due to business adjustments, the updates of the voice notification and voice verification code services have been stopped in regions outside the Chinese mainland and the services have been discontinued since March 2022. Only qualified customers can continue using the voice notification and voice verification code services.</para>
        /// <list type="bullet">
        /// <item><description>For more information about voice plans or voice service billing, see <a href="https://help.aliyun.com/document_detail/150083.html">Pricing of VMS on China site (aliyun.com)</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleCallByTtsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByTtsResponse
        /// </returns>
        public async Task<SingleCallByTtsResponse> SingleCallByTtsWithOptionsAsync(SingleCallByTtsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsCode))
            {
                query["TtsCode"] = request.TtsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParam))
            {
                query["TtsParam"] = request.TtsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleCallByTts",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleCallByTtsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a voice verification code or a voice notification with variables to a specified phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Due to business adjustments, the updates of the voice notification and voice verification code services have been stopped in regions outside the Chinese mainland and the services have been discontinued since March 2022. Only qualified customers can continue using the voice notification and voice verification code services.</para>
        /// <list type="bullet">
        /// <item><description>For more information about voice plans or voice service billing, see <a href="https://help.aliyun.com/document_detail/150083.html">Pricing of VMS on China site (aliyun.com)</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleCallByTtsRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByTtsResponse
        /// </returns>
        public SingleCallByTtsResponse SingleCallByTts(SingleCallByTtsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SingleCallByTtsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a voice verification code or a voice notification with variables to a specified phone number.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Due to business adjustments, the updates of the voice notification and voice verification code services have been stopped in regions outside the Chinese mainland and the services have been discontinued since March 2022. Only qualified customers can continue using the voice notification and voice verification code services.</para>
        /// <list type="bullet">
        /// <item><description>For more information about voice plans or voice service billing, see <a href="https://help.aliyun.com/document_detail/150083.html">Pricing of VMS on China site (aliyun.com)</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleCallByTtsRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByTtsResponse
        /// </returns>
        public async Task<SingleCallByTtsResponse> SingleCallByTtsAsync(SingleCallByTtsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SingleCallByTtsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends voice file notifications or video file notifications to a single called number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SingleCallByVideoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByVideoResponse
        /// </returns>
        public SingleCallByVideoResponse SingleCallByVideoWithOptions(SingleCallByVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoCode))
            {
                query["VideoCode"] = request.VideoCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleCallByVideo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleCallByVideoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends voice file notifications or video file notifications to a single called number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SingleCallByVideoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByVideoResponse
        /// </returns>
        public async Task<SingleCallByVideoResponse> SingleCallByVideoWithOptionsAsync(SingleCallByVideoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoCode))
            {
                query["VideoCode"] = request.VideoCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleCallByVideo",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleCallByVideoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends voice file notifications or video file notifications to a single called number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SingleCallByVideoRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByVideoResponse
        /// </returns>
        public SingleCallByVideoResponse SingleCallByVideo(SingleCallByVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SingleCallByVideoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends voice file notifications or video file notifications to a single called number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SingleCallByVideoRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByVideoResponse
        /// </returns>
        public async Task<SingleCallByVideoResponse> SingleCallByVideoAsync(SingleCallByVideoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SingleCallByVideoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a voice notification to a phone number by using a voice notification file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Due to business adjustments, the updates of the voice notification and voice verification code services have been stopped in regions outside the Chinese mainland and the services have been discontinued since March 2022. Only qualified customers can continue using the voice notification and voice verification code services.
        /// You can call the <a href="https://help.aliyun.com/document_detail/393519.html">SingleCallByTts</a> operation to send voice notifications with variables.</para>
        /// </remarks>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleCallByVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByVoiceResponse
        /// </returns>
        public SingleCallByVoiceResponse SingleCallByVoiceWithOptions(SingleCallByVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleCallByVoice",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleCallByVoiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a voice notification to a phone number by using a voice notification file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Due to business adjustments, the updates of the voice notification and voice verification code services have been stopped in regions outside the Chinese mainland and the services have been discontinued since March 2022. Only qualified customers can continue using the voice notification and voice verification code services.
        /// You can call the <a href="https://help.aliyun.com/document_detail/393519.html">SingleCallByTts</a> operation to send voice notifications with variables.</para>
        /// </remarks>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleCallByVoiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByVoiceResponse
        /// </returns>
        public async Task<SingleCallByVoiceResponse> SingleCallByVoiceWithOptionsAsync(SingleCallByVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayTimes))
            {
                query["PlayTimes"] = request.PlayTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SingleCallByVoice",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SingleCallByVoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a voice notification to a phone number by using a voice notification file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Due to business adjustments, the updates of the voice notification and voice verification code services have been stopped in regions outside the Chinese mainland and the services have been discontinued since March 2022. Only qualified customers can continue using the voice notification and voice verification code services.
        /// You can call the <a href="https://help.aliyun.com/document_detail/393519.html">SingleCallByTts</a> operation to send voice notifications with variables.</para>
        /// </remarks>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleCallByVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByVoiceResponse
        /// </returns>
        public SingleCallByVoiceResponse SingleCallByVoice(SingleCallByVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SingleCallByVoiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a voice notification to a phone number by using a voice notification file.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Due to business adjustments, the updates of the voice notification and voice verification code services have been stopped in regions outside the Chinese mainland and the services have been discontinued since March 2022. Only qualified customers can continue using the voice notification and voice verification code services.
        /// You can call the <a href="https://help.aliyun.com/document_detail/393519.html">SingleCallByTts</a> operation to send voice notifications with variables.</para>
        /// </remarks>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,200 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SingleCallByVoiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SingleCallByVoiceResponse
        /// </returns>
        public async Task<SingleCallByVoiceResponse> SingleCallByVoiceAsync(SingleCallByVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SingleCallByVoiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Fast forwards or rewinds a video when you play the video.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SkipVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SkipVideoFileResponse
        /// </returns>
        public SkipVideoFileResponse SkipVideoFileWithOptions(SkipVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipTimes))
            {
                query["SkipTimes"] = request.SkipTimes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SkipVideoFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Fast forwards or rewinds a video when you play the video.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SkipVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SkipVideoFileResponse
        /// </returns>
        public async Task<SkipVideoFileResponse> SkipVideoFileWithOptionsAsync(SkipVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipTimes))
            {
                query["SkipTimes"] = request.SkipTimes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SkipVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SkipVideoFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Fast forwards or rewinds a video when you play the video.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SkipVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// SkipVideoFileResponse
        /// </returns>
        public SkipVideoFileResponse SkipVideoFile(SkipVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SkipVideoFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Fast forwards or rewinds a video when you play the video.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SkipVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// SkipVideoFileResponse
        /// </returns>
        public async Task<SkipVideoFileResponse> SkipVideoFileAsync(SkipVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SkipVideoFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an intelligent voice call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The SmartCall operation must be used together with the <a href="https://help.aliyun.com/document_detail/112703.html">intelligent outbound HTTP operation</a>. After the call initiated by the Voice Messaging Service (VMS) platform is connected, the VMS platform sends the text converted from speech back to the business side, and the business side then returns the follow-up action to the VMS platform.</para>
        /// <list type="bullet">
        /// <item><description>The SmartCall operation does not support the following characters: <c>@ = : &quot;&quot; $ { } ^ * ￥</c>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartCallResponse
        /// </returns>
        public SmartCallResponse SmartCallWithOptions(SmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeBreak))
            {
                query["ActionCodeBreak"] = request.ActionCodeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeTimeBreak))
            {
                query["ActionCodeTimeBreak"] = request.ActionCodeTimeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrBaseId))
            {
                query["AsrBaseId"] = request.AsrBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrModelId))
            {
                query["AsrModelId"] = request.AsrModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundFileCode))
            {
                query["BackgroundFileCode"] = request.BackgroundFileCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundSpeed))
            {
                query["BackgroundSpeed"] = request.BackgroundSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundVolume))
            {
                query["BackgroundVolume"] = request.BackgroundVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicId))
            {
                query["DynamicId"] = request.DynamicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableITN))
            {
                query["EnableITN"] = request.EnableITN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteTime))
            {
                query["MuteTime"] = request.MuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoiseThreshold))
            {
                query["NoiseThreshold"] = request.NoiseThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseTime))
            {
                query["PauseTime"] = request.PauseTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFlag))
            {
                query["RecordFlag"] = request.RecordFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamAsr))
            {
                query["StreamAsr"] = request.StreamAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConf))
            {
                query["TtsConf"] = request.TtsConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsSpeed))
            {
                query["TtsSpeed"] = request.TtsSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsStyle))
            {
                query["TtsStyle"] = request.TtsStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVolume))
            {
                query["TtsVolume"] = request.TtsVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCodeParam))
            {
                query["VoiceCodeParam"] = request.VoiceCodeParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmartCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an intelligent voice call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The SmartCall operation must be used together with the <a href="https://help.aliyun.com/document_detail/112703.html">intelligent outbound HTTP operation</a>. After the call initiated by the Voice Messaging Service (VMS) platform is connected, the VMS platform sends the text converted from speech back to the business side, and the business side then returns the follow-up action to the VMS platform.</para>
        /// <list type="bullet">
        /// <item><description>The SmartCall operation does not support the following characters: <c>@ = : &quot;&quot; $ { } ^ * ￥</c>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SmartCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartCallResponse
        /// </returns>
        public async Task<SmartCallResponse> SmartCallWithOptionsAsync(SmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeBreak))
            {
                query["ActionCodeBreak"] = request.ActionCodeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodeTimeBreak))
            {
                query["ActionCodeTimeBreak"] = request.ActionCodeTimeBreak;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrBaseId))
            {
                query["AsrBaseId"] = request.AsrBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsrModelId))
            {
                query["AsrModelId"] = request.AsrModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundFileCode))
            {
                query["BackgroundFileCode"] = request.BackgroundFileCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundSpeed))
            {
                query["BackgroundSpeed"] = request.BackgroundSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundVolume))
            {
                query["BackgroundVolume"] = request.BackgroundVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledShowNumber))
            {
                query["CalledShowNumber"] = request.CalledShowNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicId))
            {
                query["DynamicId"] = request.DynamicId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarlyMediaAsr))
            {
                query["EarlyMediaAsr"] = request.EarlyMediaAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableITN))
            {
                query["EnableITN"] = request.EnableITN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MuteTime))
            {
                query["MuteTime"] = request.MuteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoiseThreshold))
            {
                query["NoiseThreshold"] = request.NoiseThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PauseTime))
            {
                query["PauseTime"] = request.PauseTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordFlag))
            {
                query["RecordFlag"] = request.RecordFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionTimeout))
            {
                query["SessionTimeout"] = request.SessionTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Speed))
            {
                query["Speed"] = request.Speed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StreamAsr))
            {
                query["StreamAsr"] = request.StreamAsr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsConf))
            {
                query["TtsConf"] = request.TtsConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsSpeed))
            {
                query["TtsSpeed"] = request.TtsSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsStyle))
            {
                query["TtsStyle"] = request.TtsStyle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsVolume))
            {
                query["TtsVolume"] = request.TtsVolume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCode))
            {
                query["VoiceCode"] = request.VoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VoiceCodeParam))
            {
                query["VoiceCodeParam"] = request.VoiceCodeParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmartCall",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an intelligent voice call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The SmartCall operation must be used together with the <a href="https://help.aliyun.com/document_detail/112703.html">intelligent outbound HTTP operation</a>. After the call initiated by the Voice Messaging Service (VMS) platform is connected, the VMS platform sends the text converted from speech back to the business side, and the business side then returns the follow-up action to the VMS platform.</para>
        /// <list type="bullet">
        /// <item><description>The SmartCall operation does not support the following characters: <c>@ = : &quot;&quot; $ { } ^ * ￥</c>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartCallResponse
        /// </returns>
        public SmartCallResponse SmartCall(SmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmartCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an intelligent voice call.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The SmartCall operation must be used together with the <a href="https://help.aliyun.com/document_detail/112703.html">intelligent outbound HTTP operation</a>. After the call initiated by the Voice Messaging Service (VMS) platform is connected, the VMS platform sends the text converted from speech back to the business side, and the business side then returns the follow-up action to the VMS platform.</para>
        /// <list type="bullet">
        /// <item><description>The SmartCall operation does not support the following characters: <c>@ = : &quot;&quot; $ { } ^ * ￥</c>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 1,000 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SmartCallRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartCallResponse
        /// </returns>
        public async Task<SmartCallResponse> SmartCallAsync(SmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmartCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an action in an outbound robocall. This operation is applicable only when the robocall is transferred to an agent or an agent is listening in on the conversation between the robot and the user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate a specified action on the called number of an outbound robocall when the call is transferred to an agent of the call center.</para>
        /// <remarks>
        /// <para>You can only initiate the action of bridging a called number and an agent of the call center.</para>
        /// </remarks>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SmartCallOperateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartCallOperateResponse
        /// </returns>
        public SmartCallOperateResponse SmartCallOperateWithOptions(SmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmartCallOperate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartCallOperateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an action in an outbound robocall. This operation is applicable only when the robocall is transferred to an agent or an agent is listening in on the conversation between the robot and the user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate a specified action on the called number of an outbound robocall when the call is transferred to an agent of the call center.</para>
        /// <remarks>
        /// <para>You can only initiate the action of bridging a called number and an agent of the call center.</para>
        /// </remarks>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SmartCallOperateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmartCallOperateResponse
        /// </returns>
        public async Task<SmartCallOperateResponse> SmartCallOperateWithOptionsAsync(SmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                query["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmartCallOperate",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmartCallOperateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an action in an outbound robocall. This operation is applicable only when the robocall is transferred to an agent or an agent is listening in on the conversation between the robot and the user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate a specified action on the called number of an outbound robocall when the call is transferred to an agent of the call center.</para>
        /// <remarks>
        /// <para>You can only initiate the action of bridging a called number and an agent of the call center.</para>
        /// </remarks>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SmartCallOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartCallOperateResponse
        /// </returns>
        public SmartCallOperateResponse SmartCallOperate(SmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmartCallOperateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates an action in an outbound robocall. This operation is applicable only when the robocall is transferred to an agent or an agent is listening in on the conversation between the robot and the user.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to initiate a specified action on the called number of an outbound robocall when the call is transferred to an agent of the call center.</para>
        /// <remarks>
        /// <para>You can only initiate the action of bridging a called number and an agent of the call center.</para>
        /// </remarks>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SmartCallOperateRequest
        /// </param>
        /// 
        /// <returns>
        /// SmartCallOperateResponse
        /// </returns>
        public async Task<SmartCallOperateResponse> SmartCallOperateAsync(SmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmartCallOperateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a robocall task immediately or at a scheduled time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartRobotTaskResponse
        /// </returns>
        public StartRobotTaskResponse StartRobotTaskWithOptions(StartRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRobotTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a robocall task immediately or at a scheduled time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartRobotTaskResponse
        /// </returns>
        public async Task<StartRobotTaskResponse> StartRobotTaskWithOptionsAsync(StartRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTime))
            {
                query["ScheduleTime"] = request.ScheduleTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartRobotTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a robocall task immediately or at a scheduled time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartRobotTaskResponse
        /// </returns>
        public StartRobotTaskResponse StartRobotTask(StartRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRobotTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a robocall task immediately or at a scheduled time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StartRobotTaskResponse
        /// </returns>
        public async Task<StartRobotTaskResponse> StartRobotTaskAsync(StartRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRobotTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the inbound call that is transferred from a China 400 number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCallInConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCallInConfigResponse
        /// </returns>
        public StopCallInConfigResponse StopCallInConfigWithOptions(StopCallInConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCallInConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCallInConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the inbound call that is transferred from a China 400 number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCallInConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopCallInConfigResponse
        /// </returns>
        public async Task<StopCallInConfigResponse> StopCallInConfigWithOptionsAsync(StopCallInConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Number))
            {
                query["Number"] = request.Number;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopCallInConfig",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCallInConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the inbound call that is transferred from a China 400 number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCallInConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCallInConfigResponse
        /// </returns>
        public StopCallInConfigResponse StopCallInConfig(StopCallInConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCallInConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops the inbound call that is transferred from a China 400 number.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopCallInConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// StopCallInConfigResponse
        /// </returns>
        public async Task<StopCallInConfigResponse> StopCallInConfigAsync(StopCallInConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCallInConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a robocall task that is in progress.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you stop a robocall task, you can call the <a href="~~StartRobotTask~~">StartRobotTask</a> operation to start it again.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopRobotTaskResponse
        /// </returns>
        public StopRobotTaskResponse StopRobotTaskWithOptions(StopRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopRobotTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a robocall task that is in progress.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you stop a robocall task, you can call the <a href="~~StartRobotTask~~">StartRobotTask</a> operation to start it again.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopRobotTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopRobotTaskResponse
        /// </returns>
        public async Task<StopRobotTaskResponse> StopRobotTaskWithOptionsAsync(StopRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopRobotTask",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopRobotTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a robocall task that is in progress.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you stop a robocall task, you can call the <a href="~~StartRobotTask~~">StartRobotTask</a> operation to start it again.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopRobotTaskResponse
        /// </returns>
        public StopRobotTaskResponse StopRobotTask(StopRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRobotTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a robocall task that is in progress.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you stop a robocall task, you can call the <a href="~~StartRobotTask~~">StartRobotTask</a> operation to start it again.</para>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopRobotTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopRobotTaskResponse
        /// </returns>
        public async Task<StopRobotTaskResponse> StopRobotTaskAsync(StopRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRobotTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a 400 number for registration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitHotlineTransferRegisterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitHotlineTransferRegisterResponse
        /// </returns>
        public SubmitHotlineTransferRegisterResponse SubmitHotlineTransferRegisterWithOptions(SubmitHotlineTransferRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Agreement))
            {
                query["Agreement"] = request.Agreement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                query["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorIdentityCard))
            {
                query["OperatorIdentityCard"] = request.OperatorIdentityCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorMail))
            {
                query["OperatorMail"] = request.OperatorMail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorMailVerifyCode))
            {
                query["OperatorMailVerifyCode"] = request.OperatorMailVerifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorMobile))
            {
                query["OperatorMobile"] = request.OperatorMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorMobileVerifyCode))
            {
                query["OperatorMobileVerifyCode"] = request.OperatorMobileVerifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorName))
            {
                query["OperatorName"] = request.OperatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferPhoneNumberInfos))
            {
                query["TransferPhoneNumberInfos"] = request.TransferPhoneNumberInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitHotlineTransferRegister",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitHotlineTransferRegisterResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a 400 number for registration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitHotlineTransferRegisterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitHotlineTransferRegisterResponse
        /// </returns>
        public async Task<SubmitHotlineTransferRegisterResponse> SubmitHotlineTransferRegisterWithOptionsAsync(SubmitHotlineTransferRegisterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Agreement))
            {
                query["Agreement"] = request.Agreement;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotlineNumber))
            {
                query["HotlineNumber"] = request.HotlineNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorIdentityCard))
            {
                query["OperatorIdentityCard"] = request.OperatorIdentityCard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorMail))
            {
                query["OperatorMail"] = request.OperatorMail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorMailVerifyCode))
            {
                query["OperatorMailVerifyCode"] = request.OperatorMailVerifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorMobile))
            {
                query["OperatorMobile"] = request.OperatorMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorMobileVerifyCode))
            {
                query["OperatorMobileVerifyCode"] = request.OperatorMobileVerifyCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorName))
            {
                query["OperatorName"] = request.OperatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationId))
            {
                query["QualificationId"] = request.QualificationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferPhoneNumberInfos))
            {
                query["TransferPhoneNumberInfos"] = request.TransferPhoneNumberInfos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitHotlineTransferRegister",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitHotlineTransferRegisterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a 400 number for registration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitHotlineTransferRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitHotlineTransferRegisterResponse
        /// </returns>
        public SubmitHotlineTransferRegisterResponse SubmitHotlineTransferRegister(SubmitHotlineTransferRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitHotlineTransferRegisterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a 400 number for registration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SubmitHotlineTransferRegisterRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitHotlineTransferRegisterResponse
        /// </returns>
        public async Task<SubmitHotlineTransferRegisterResponse> SubmitHotlineTransferRegisterAsync(SubmitHotlineTransferRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitHotlineTransferRegisterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades from a voice call to a video call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeVideoFileResponse
        /// </returns>
        public UpgradeVideoFileResponse UpgradeVideoFileWithOptions(UpgradeVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeVideoFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades from a voice call to a video call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeVideoFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeVideoFileResponse
        /// </returns>
        public async Task<UpgradeVideoFileResponse> UpgradeVideoFileWithOptionsAsync(UpgradeVideoFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutId))
            {
                query["OutId"] = request.OutId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeVideoFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeVideoFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades from a voice call to a video call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeVideoFileResponse
        /// </returns>
        public UpgradeVideoFileResponse UpgradeVideoFile(UpgradeVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeVideoFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades from a voice call to a video call.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpgradeVideoFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeVideoFileResponse
        /// </returns>
        public async Task<UpgradeVideoFileResponse> UpgradeVideoFileAsync(UpgradeVideoFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeVideoFileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads the called numbers of a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadRobotTaskCalledFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadRobotTaskCalledFileResponse
        /// </returns>
        public UploadRobotTaskCalledFileResponse UploadRobotTaskCalledFileWithOptions(UploadRobotTaskCalledFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParam))
            {
                query["TtsParam"] = request.TtsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParamHead))
            {
                query["TtsParamHead"] = request.TtsParamHead;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadRobotTaskCalledFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRobotTaskCalledFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads the called numbers of a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadRobotTaskCalledFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadRobotTaskCalledFileResponse
        /// </returns>
        public async Task<UploadRobotTaskCalledFileResponse> UploadRobotTaskCalledFileWithOptionsAsync(UploadRobotTaskCalledFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CalledNumber))
            {
                query["CalledNumber"] = request.CalledNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParam))
            {
                query["TtsParam"] = request.TtsParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TtsParamHead))
            {
                query["TtsParamHead"] = request.TtsParamHead;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadRobotTaskCalledFile",
                Version = "2017-05-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRobotTaskCalledFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads the called numbers of a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadRobotTaskCalledFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadRobotTaskCalledFileResponse
        /// </returns>
        public UploadRobotTaskCalledFileResponse UploadRobotTaskCalledFile(UploadRobotTaskCalledFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadRobotTaskCalledFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads the called numbers of a robocall task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limits</h3>
        /// <para>You can call this operation up to 100 times per second per account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadRobotTaskCalledFileRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadRobotTaskCalledFileResponse
        /// </returns>
        public async Task<UploadRobotTaskCalledFileResponse> UploadRobotTaskCalledFileAsync(UploadRobotTaskCalledFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadRobotTaskCalledFileWithOptionsAsync(request, runtime);
        }

    }
}
