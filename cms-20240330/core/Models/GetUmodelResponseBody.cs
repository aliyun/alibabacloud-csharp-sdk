// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetUmodelResponseBody : TeaModel {
        /// <summary>
        /// <para>This field does not need to be filled currently</para>
        /// </summary>
        [NameInMap("commonSchemaRef")]
        [Validation(Required=false)]
        public List<GetUmodelResponseBodyCommonSchemaRef> CommonSchemaRef { get; set; }
        public class GetUmodelResponseBodyCommonSchemaRef : TeaModel {
            /// <summary>
            /// <para>Common Umodel Schema group</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-job-123123</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>Version</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Umodel description</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Region</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-heyuan</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123123-sdf-435-3123</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Workspace name</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
