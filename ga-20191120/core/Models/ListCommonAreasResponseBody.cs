// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListCommonAreasResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the areas.</para>
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListCommonAreasResponseBodyAreas> Areas { get; set; }
        public class ListCommonAreasResponseBodyAreas : TeaModel {
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
            /// <para>The area name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>North China</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The information about the regions.</para>
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListCommonAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListCommonAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// <para>The region name.</para>
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
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
