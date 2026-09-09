// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class GetDigitalEmployeeUmodelResponseBody : TeaModel {
        /// <summary>
        /// <para>The common schemas referenced by the digital employee UModel.</para>
        /// </summary>
        [NameInMap("commonSchemaRef")]
        [Validation(Required=false)]
        public List<GetDigitalEmployeeUmodelResponseBodyCommonSchemaRef> CommonSchemaRef { get; set; }
        public class GetDigitalEmployeeUmodelResponseBodyCommonSchemaRef : TeaModel {
            /// <summary>
            /// <para>The schema group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The schema version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The description of the digital employee UModel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the digital employee to which the UModel belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample-agent</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-1234567890AB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
