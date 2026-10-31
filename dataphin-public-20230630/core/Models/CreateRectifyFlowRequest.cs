// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateRectifyFlowRequest : TeaModel {
        /// <summary>
        /// <para>The business request parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateRectifyFlowRequestCreateCommand CreateCommand { get; set; }
        public class CreateRectifyFlowRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>Specifies whether to associate with an existing process. Default value: false.</para>
            /// </summary>
            [NameInMap("BindToRectify")]
            [Validation(Required=false)]
            public bool? BindToRectify { get; set; }

            /// <summary>
            /// <para>This parameter is required when you associate with an existing process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>117970862340</para>
            /// </summary>
            [NameInMap("BindToRectifyId")]
            [Validation(Required=false)]
            public long? BindToRectifyId { get; set; }

            /// <summary>
            /// <para>The operation description. This parameter is optional. Maximum length: 128 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initiate quality issue rectification for the customer table</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The governance object type. Valid values: TABLE, DATASOURCE_TABLE, DATASOURCE, INDEX, REALTIME_LOGICAL_TABLE, and QD_FEATURE.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("GovernItemType")]
            [Validation(Required=false)]
            public string GovernItemType { get; set; }

            /// <summary>
            /// <para>The list of issue IDs. Issues that cannot be rectified are skipped. If all issues are skipped, the original business error is returned.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("GovernObjectIds")]
            [Validation(Required=false)]
            public List<long?> GovernObjectIds { get; set; }

            /// <summary>
            /// <para>The rectification name. This parameter is required when you create a process and can contain up to 128 characters. It is ignored when you associate with an existing process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Quality issue rectification for the customer table</para>
            /// </summary>
            [NameInMap("RectifyName")]
            [Validation(Required=false)]
            public string RectifyName { get; set; }

            /// <summary>
            /// <para>The rectification priority. Valid values: HIGH, MIDDLE, and LOW. Default value: MIDDLE. This parameter is ignored and not verified when you associate with an existing process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MIDDLE</para>
            /// </summary>
            [NameInMap("RectifyPriority")]
            [Validation(Required=false)]
            public string RectifyPriority { get; set; }

            /// <summary>
            /// <para>The rectification scope. Valid values: QUALITY_RULE_SCOPE, QUALITY_RULE_TASK_SCOPE, QUALITY_GOVERN_OBJECT_SCOPE, and QUALITY_WATCH_SCOPE. The default value is the same as the value on the page. A rule scope may include other issues.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QUALITY_GOVERN_OBJECT_SCOPE</para>
            /// </summary>
            [NameInMap("RectifyScope")]
            [Validation(Required=false)]
            public string RectifyScope { get; set; }

            /// <summary>
            /// <para>The ID of the user who performs the rectification. Default value: the current user. This parameter is ignored when you associate with an existing process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("RectifyUser")]
            [Validation(Required=false)]
            public string RectifyUser { get; set; }

            /// <summary>
            /// <para>The ID of the user who performs the verification. Default value: the current user. This parameter is ignored when you associate with an existing process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user002</para>
            /// </summary>
            [NameInMap("VerifyUser")]
            [Validation(Required=false)]
            public string VerifyUser { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
