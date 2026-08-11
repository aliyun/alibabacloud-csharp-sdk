// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListParameterSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results returned per page. Default value: 20. Minimum value: 1. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The parameter sets.</para>
        /// </summary>
        [NameInMap("parameterSets")]
        [Validation(Required=false)]
        public List<ListParameterSetsResponseBodyParameterSets> ParameterSets { get; set; }
        public class ListParameterSetsResponseBodyParameterSets : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC, in the ISO 8601 format of YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-14T10:05:19Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("deletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The description of the parameter set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is parameterSet</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the parameter set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the parameter set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pts-433aead756057ea135b21e89c</para>
            /// </summary>
            [NameInMap("parameterSetId")]
            [Validation(Required=false)]
            public string ParameterSetId { get; set; }

            /// <summary>
            /// <para>The parameters in the parameter set.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<ListParameterSetsResponseBodyParameterSetsParameters> Parameters { get; set; }
            public class ListParameterSetsResponseBodyParameterSetsParameters : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the parameter is a secret parameter. Secret parameters are hidden in API responses and console displays, and are stored with encryption.</para>
                /// </summary>
                [NameInMap("secret")]
                [Validation(Required=false)]
                public bool? Secret { get; set; }

                /// <summary>
                /// <para>The parameter set status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>HAS_VALUE (default): A specific value is defined.</para>
                /// </description></item>
                /// <item><description><para>EXPLICIT_NULL: Explicitly set to null.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HAS_VALUE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The parameter type (string/number/bool/map(string)/list(string)).</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The associated resources.</para>
            /// </summary>
            [NameInMap("relationList")]
            [Validation(Required=false)]
            public List<ListParameterSetsResponseBodyParameterSetsRelationList> RelationList { get; set; }
            public class ListParameterSetsResponseBodyParameterSetsRelationList : TeaModel {
                /// <summary>
                /// <para>The creation time in UTC, in the ISO 8601 format of YYYY-MM-DDTHH:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-06-09T03:46:18Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The resource ID. When the resource type is ModuleVersion, the ID is composed of <moduleId>-<moduleversion>, such as mod-34535345df123fr-v3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task-433aead756057ffdf5326bf1e12ed</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Module: template.</description></item>
                /// <item><description>ModuleVersion: template version.</description></item>
                /// <item><description>Task: task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Module</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E188A8C-D77A-53F2-9578-E9AD8ABF2FA9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
