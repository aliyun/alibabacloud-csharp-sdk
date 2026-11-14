// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListWuyingServerWorkloadTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The compatibility field. The current version does not use this field to indicate the number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The compatibility field. The current version does not generate a next page token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unused</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID to troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of workload templates. The templates are returned in the order of their configuration, with a maximum of 100 entries.</para>
        /// </summary>
        [NameInMap("WorkloadTemplates")]
        [Validation(Required=false)]
        public List<ListWuyingServerWorkloadTemplateResponseBodyWorkloadTemplates> WorkloadTemplates { get; set; }
        public class ListWuyingServerWorkloadTemplateResponseBodyWorkloadTemplates : TeaModel {
            /// <summary>
            /// <para>The rendered template content. The original text is Base64-encoded after being encoded in UTF-8. You must decode the Base64 string before use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IyB3b3JrbG9hZCB0ZW1wbGF0ZQo=</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The description of the workload template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used to submit general-purpose computing workloads</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the workload template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General-purpose computing task template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
