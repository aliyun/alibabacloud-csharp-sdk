// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAttackAppCategoryResponseBody : TeaModel {
        [NameInMap("AppCategories")]
        [Validation(Required=false)]
        public List<DescribeAttackAppCategoryResponseBodyAppCategories> AppCategories { get; set; }
        public class DescribeAttackAppCategoryResponseBodyAppCategories : TeaModel {
            [NameInMap("AttackApps")]
            [Validation(Required=false)]
            public List<string> AttackApps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B14757D0-4640-4B44-AC67-7F558FE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
