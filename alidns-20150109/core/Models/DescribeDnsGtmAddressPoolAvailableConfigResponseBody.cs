// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAddressPoolAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The supported source regions.</para>
        /// </summary>
        [NameInMap("AttributeInfos")]
        [Validation(Required=false)]
        public DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos AttributeInfos { get; set; }
        public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfos : TeaModel {
            [NameInMap("AttributeInfo")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfosAttributeInfo> AttributeInfo { get; set; }
            public class DescribeDnsGtmAddressPoolAvailableConfigResponseBodyAttributeInfosAttributeInfo : TeaModel {
                /// <summary>
                /// <para>The parent line code of the source region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>telecom</para>
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// <para>The code of the source region group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <para>The name of the request source group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The line code of the source region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// <para>The line name of the source region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>199C3699-9A7B-41A1-BB5A-F1E862D3CB38</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
