// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSLSRealTimeLogTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnSLSRealTimeLogTypeResponseBodyContent Content { get; set; }
        public class DescribeDcdnSLSRealTimeLogTypeResponseBodyContent : TeaModel {
            [NameInMap("Business")]
            [Validation(Required=false)]
            public List<DescribeDcdnSLSRealTimeLogTypeResponseBodyContentBusiness> Business { get; set; }
            public class DescribeDcdnSLSRealTimeLogTypeResponseBodyContentBusiness : TeaModel {
                /// <summary>
                /// <para>The type of real-time logs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>dcdn_log_access_l1</b>: access logs.</description></item>
                /// <item><description><b>dcdn_log_er</b>: EdgeRoutine logs</description></item>
                /// <item><description><b>dcdn_log_waf</b>: WAF interception logs</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dcdn_log_access_l1</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <para>The description of the real-time log type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product_U8JE</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
