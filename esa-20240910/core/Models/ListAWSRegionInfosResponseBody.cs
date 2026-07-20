// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListAWSRegionInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The region information.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<ListAWSRegionInfosResponseBodyRegions> Regions { get; set; }
        public class ListAWSRegionInfosResponseBodyRegions : TeaModel {
            /// <summary>
            /// <para>The region code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-east-2</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US East (Ohio)</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
