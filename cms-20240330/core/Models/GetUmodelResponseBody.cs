// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetUmodelResponseBody : TeaModel {
        [NameInMap("commonSchemaRef")]
        [Validation(Required=false)]
        public List<GetUmodelResponseBodyCommonSchemaRef> CommonSchemaRef { get; set; }
        public class GetUmodelResponseBodyCommonSchemaRef : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-job-123123</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<string> Items { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-heyuan</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123-123123-sdf-435-3123</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
