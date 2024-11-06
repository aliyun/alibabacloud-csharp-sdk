// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRealTimeDeliveryFieldResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnRealTimeDeliveryFieldResponseBodyContent Content { get; set; }
        public class DescribeDcdnRealTimeDeliveryFieldResponseBodyContent : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeDcdnRealTimeDeliveryFieldResponseBodyContentFields> Fields { get; set; }
            public class DescribeDcdnRealTimeDeliveryFieldResponseBodyContentFields : TeaModel {
                /// <summary>
                /// <para>The description of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Access time</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the field. For more information about fields in real-time log entries, see <a href="https://help.aliyun.com/document_detail/324199.html">Fields in a real-time log</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unixtime</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

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
