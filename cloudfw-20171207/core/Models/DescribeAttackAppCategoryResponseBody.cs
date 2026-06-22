// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAttackAppCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of attack application categories.</para>
        /// </summary>
        [NameInMap("AppCategories")]
        [Validation(Required=false)]
        public List<DescribeAttackAppCategoryResponseBodyAppCategories> AppCategories { get; set; }
        public class DescribeAttackAppCategoryResponseBodyAppCategories : TeaModel {
            /// <summary>
            /// <para>The list of attack applications.</para>
            /// </summary>
            [NameInMap("AttackApps")]
            [Validation(Required=false)]
            public List<string> AttackApps { get; set; }

            /// <summary>
            /// <para>The name of the attack application category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

        }

        /// <summary>
        /// <para>The request ID of the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B14757D0-4640-4B44-AC67-7F558FE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
