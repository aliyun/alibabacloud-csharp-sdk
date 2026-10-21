// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAccessPointResponseBody : TeaModel {
        /// <summary>
        /// <para>The access point.</para>
        /// </summary>
        [NameInMap("AccessPoint")]
        [Validation(Required=false)]
        public CreateAccessPointResponseBodyAccessPoint AccessPoint { get; set; }
        public class CreateAccessPointResponseBodyAccessPoint : TeaModel {
            /// <summary>
            /// <para>The domain name of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-ie15ydanoz.001014****-w****.cn-hangzhou.nas.aliyuncs.com</para>
            /// </summary>
            [NameInMap("AccessPointDomain")]
            [Validation(Required=false)]
            public string AccessPointDomain { get; set; }

            /// <summary>
            /// <para>The ID of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-ie15yd****</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
