// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeFaceGuardRiskRequest : TeaModel {
        /// <summary>
        /// <para>Authentication ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>aba9830f471a4335af4612c8adaa91b0</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>Risk identification - device token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>McozS1ZWRcRZStlERcZZo_QOytx5jcgZoZJEoRLOxxxxxxx</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <para>This identifier is used for subsequent troubleshooting, and you need to ensure that this value is unique in your business.</para>
        /// <para>Supports the use of English letters (including uppercase and lowercase) and numbers, with a maximum length of 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35xxxx</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>Product code, fixed value: FACE_GUARD</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_GUARD</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
