// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAccelerateAreasResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the areas.</para>
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAccelerateAreasResponseBodyAreas : TeaModel {
            /// <summary>
            /// <para>The area ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huabei</para>
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// <para>The name of the area.</para>
            /// 
            /// <b>Example:</b>
            /// <para>North China</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The regions in the acceleration area.</para>
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Qingdao)</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FEA0CF3-D3B9-43E5-A304-D217037876A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
