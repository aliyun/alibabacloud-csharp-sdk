// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppSecuritiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The associated security policy information.</para>
        /// </summary>
        [NameInMap("AppSecuritys")]
        [Validation(Required=false)]
        public DescribeAppSecuritiesResponseBodyAppSecuritys AppSecuritys { get; set; }
        public class DescribeAppSecuritiesResponseBodyAppSecuritys : TeaModel {
            [NameInMap("AppSecurity")]
            [Validation(Required=false)]
            public List<DescribeAppSecuritiesResponseBodyAppSecuritysAppSecurity> AppSecurity { get; set; }
            public class DescribeAppSecuritiesResponseBodyAppSecuritysAppSecurity : TeaModel {
                /// <summary>
                /// <para>The application AppCode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d2350ecd62c44cbfbe35a7f182e35105</para>
                /// </summary>
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                /// <summary>
                /// <para>The application AppKey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34379343</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The application AppSecret.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ea5291a7aff343769eb3139a2f6de8c9</para>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                /// <summary>
                /// <para>The time when the AppKey was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-14T18:50:59</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The time when the AppSecret was last modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-14T18:03:00+08:00</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF924FE4-2EDD-4CD3-89EC-34E4708574E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
