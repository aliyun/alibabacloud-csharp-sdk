// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class GetTrialAccessChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing status code. A value of OK indicates success. When an exception occurs, the corresponding business error code is returned. The error types and mapping rules follow the current API configuration. No error codes are added or modified in this update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The channel configuration corresponding to the VisitorToken and its associated scenarios, used for trial page initialization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InstanceId&quot;:&quot;instance-example-001&quot;,&quot;AccessChannelId&quot;:&quot;66666666-7777-4888-8999-000000000000&quot;,&quot;AccessChannelType&quot;:&quot;TEST&quot;,&quot;Name&quot;:&quot;Product consultation trial&quot;,&quot;State&quot;:&quot;Active&quot;,&quot;ChannelSetting&quot;:&quot;{}&quot;,&quot;VisitorToken&quot;:&quot;example-visitor-token&quot;,&quot;ExpirationTime&quot;:1794564000000,&quot;CreatedTime&quot;:1794556800000,&quot;UpdatedTime&quot;:1794560400000,&quot;ChannelScripts&quot;:[{&quot;ScriptId&quot;:&quot;script-example-001&quot;,&quot;ScriptName&quot;:&quot;Product consultation&quot;,&quot;VariableConfigs&quot;:&quot;[]&quot;,&quot;LabelConfigs&quot;:&quot;[]&quot;}],&quot;NluEngine&quot;:&quot;BEEBOT&quot;,&quot;BuilderType&quot;:&quot;FLOW&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTrialAccessChannelResponseBodyData Data { get; set; }
        public class GetTrialAccessChannelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the channel associated with the trial link or specific access configuration. When a channel needs to be associated, use the ID actually returned by the channel service. It is not the ChannelId returned by a call, and the two must not be mixed. The configuration layer uses a UUID as the channel ID when creating a new channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66666666-7777-4888-8999-000000000000</para>
            /// </summary>
            [NameInMap("AccessChannelId")]
            [Validation(Required=false)]
            public string AccessChannelId { get; set; }

            /// <summary>
            /// <para>Identifies the access source of the current interaction. The configuration layer enumerations are TEST (voice test window or real number outbound call test), TEXT_TEST (text test window), TRIAL (web voice trial link), and TEXT_TRIAL (text trial link). The existing default values and visibility of each API remain unchanged. If the current definition uses the historical value Text, it should be processed according to the existing definition and is not modified in this documentation update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEST</para>
            /// </summary>
            [NameInMap("AccessChannelType")]
            [Validation(Required=false)]
            public string AccessChannelType { get; set; }

            /// <summary>
            /// <para>The scenario building method. The configuration layer enumerations are FLOW and LITE. This field is not declared in the current business layer channel response object. Therefore, whether it is actually returned depends on the deployment version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FLOW</para>
            /// </summary>
            [NameInMap("BuilderType")]
            [Validation(Required=false)]
            public string BuilderType { get; set; }

            /// <summary>
            /// <para>The scenarios associated with this channel and their display, variable, and label configurations. The trial page should use the ScriptId actually returned in the list and must not specify scenarios outside the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ScriptId&quot;:&quot;script-example-001&quot;,&quot;ScriptName&quot;:&quot;Product consultation&quot;,&quot;VariableConfigs&quot;:&quot;[]&quot;,&quot;LabelConfigs&quot;:&quot;[]&quot;}]</para>
            /// </summary>
            [NameInMap("ChannelScripts")]
            [Validation(Required=false)]
            public List<GetTrialAccessChannelResponseBodyDataChannelScripts> ChannelScripts { get; set; }
            public class GetTrialAccessChannelResponseBodyDataChannelScripts : TeaModel {
                /// <summary>
                /// <para>The JSON string of the label configuration exported from the scenario version. The specific fields are determined by the scenario version. The empty JSON array in the example only indicates that there are no configuration items and must not be confused with the call parameter Tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("LabelConfigs")]
                [Validation(Required=false)]
                public string LabelConfigs { get; set; }

                /// <summary>
                /// <para>The ID of the dialog scenario under the instance. Specify an existing scenario. Subsequent dialogs and end requests for the same text session should use the scenario specified when the session is started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>script-example-001</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The name of the scenario associated with the channel, used for display on the trial page. Use the actual value returned by the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product consultation</para>
                /// </summary>
                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <para>The JSON string of the variable configuration exported from the scenario version. It is not the variable values passed in this interaction. The specific configuration items are determined by the scenario version. The empty JSON array in the example only indicates that there are no configuration items and does not declare unverified internal fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("VariableConfigs")]
                [Validation(Required=false)]
                public string VariableConfigs { get; set; }

            }

            /// <summary>
            /// <para>The display configuration of the trial channel, which is a JSON object string. The content is configured during channel creation and agreed upon with the trial page, and may include display information such as Images. The current code does not provide a complete fixed structure, and the empty object in the example only illustrates the serialization format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ChannelSetting")]
            [Validation(Required=false)]
            public string ChannelSetting { get; set; }

            /// <summary>
            /// <para>The creation time of the channel, in Unix timestamp format and measured in milliseconds. It is converted from the creation time of the configuration layer entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794556800000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the trial channel and the visitor token, in Unix timestamp format and measured in milliseconds. The service compares the validity period with the current system time in milliseconds. Expired tokens cannot continue the trial.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794564000000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>The instance identity of the product to which it belongs. You must use an instance that the invoker has permission to access and that actually exists. It must be consistent with the instance to which the scenario, channel, and session belong. The maximum length is subject to the current POP parameter definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance-example-001</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the trial channel, used for display and identification on the trial page. The content is configured by the channel creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product consultation trial</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The natural language understanding (NLU) engine type defined in the configuration layer. Valid values: BEEBOT, PROMPTS, and FUNCTION. This field is not declared in the current business layer channel response object. Therefore, whether it can be returned through this operation depends on the deployment version and must not be assumed to always exist on the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BEEBOT</para>
            /// </summary>
            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            /// <summary>
            /// <para>The channel status. Valid values: Active (effective) and Expired (invalid). Trial access still requires server-side token and validity period verification. You cannot bypass the verification based solely on the status value saved on the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The last update time of the channel, in Unix timestamp format and measured in milliseconds. It is converted from the update time of the configuration layer entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1794560400000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The visitor token obtained from the trial link. It is used to locate the trial channel and verify access permissions and the validity period. The token is generated by the channel service and must not be constructed manually. It cannot be empty and must be within its validity period. The example is a placeholder value that cannot be used for authentication. Do not disclose actual tokens to unauthorized personnel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-visitor-token</para>
            /// </summary>
            [NameInMap("VisitorToken")]
            [Validation(Required=false)]
            public string VisitorToken { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code recorded in the business response body. A normal return value is 200. To determine whether the business operation is successful, you must also check the Code field. The presence of this field alone does not indicate a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The business response or error description. It is usually empty or not returned upon success, and a fixed text cannot be required for successful responses. Upon failure, it provides an error description to assist in troubleshooting. Combine it with Code and Params to understand the cause of the error. The example shows an error message when the trial link visitor token expires (corresponding to the Code Expired.VisitorToken) and is for format reference only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VisitorToken: example-visitor-token is expired.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID used to associate and troubleshoot this POP request. The value in the response corresponds to the current request. System request parameters are injected by the gateway, and callers do not need to fill in system fields manually.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAAAA-BBBB-4CCC-8DDD-EEEEEEEEEEEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the business processing is successful. A value of true indicates success, and false indicates failure. The current general response implementation determines success based on whether the Code is OK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
