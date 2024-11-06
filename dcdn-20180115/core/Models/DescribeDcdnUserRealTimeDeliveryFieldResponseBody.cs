// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserRealTimeDeliveryFieldResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContent Content { get; set; }
        public class DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContent : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContentFields> Fields { get; set; }
            public class DescribeDcdnUserRealTimeDeliveryFieldResponseBodyContentFields : TeaModel {
                /// <summary>
                /// <para>The description of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The timestamp of the request</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unixtime</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>Indicates whether the field was selected.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3EACD23C-F49F-4BF7-B9AD-C2CD3BA888C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
