// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetApiSchemaUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-agknce3n****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of files uploaded for schema verification in the plan instance of the website.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceUsage")]
        [Validation(Required=false)]
        public int? InstanceUsage { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>952ea16b-1f05-4a76-bb32-420282d8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Usage details for websites.</para>
        /// </summary>
        [NameInMap("Usages")]
        [Validation(Required=false)]
        public List<GetApiSchemaUsageResponseBodyUsages> Usages { get; set; }
        public class GetApiSchemaUsageResponseBodyUsages : TeaModel {
            /// <summary>
            /// <para>The website ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40000449</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The website name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of files uploaded for the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public int? Usage { get; set; }

        }

    }

}
