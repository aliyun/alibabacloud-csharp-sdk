// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetClassificationTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the classification template that is associated to the instance.</para>
        /// </summary>
        [NameInMap("ClassificationResourceTemplateMap")]
        [Validation(Required=false)]
        public GetClassificationTemplateResponseBodyClassificationResourceTemplateMap ClassificationResourceTemplateMap { get; set; }
        public class GetClassificationTemplateResponseBodyClassificationResourceTemplateMap : TeaModel {
            /// <summary>
            /// <para>The ID of the resource. The supported resource type is INSTANCE. The resource ID corresponds to the value of InstanceId. You can call the <a href="https://help.aliyun.com/document_detail/141936.html">ListInstances</a> operation to obtain the value of InstanceId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public long? ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type. The value is fixed as <b>INSTANCE</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCE</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3***</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The type of the classification and grading template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INNER</b>: a built-in template.</description></item>
            /// <item><description><b>USER_DEFINE</b>: a custom template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INNER</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>427688B8-ADFB-4C4E-9D45-EF5C1FD6E23D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
