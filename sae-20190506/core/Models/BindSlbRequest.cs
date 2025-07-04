// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BindSlbRequest : TeaModel {
        /// <summary>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1\<em>\</em>\<em>\</em></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>[{&quot;port&quot;:80,&quot;targetPort&quot;:8080,&quot;protocol&quot;:&quot;TCP&quot;}]</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;port&quot;:80,&quot;targetPort&quot;:8080,&quot;protocol&quot;:&quot;TCP&quot;}]</para>
        /// </summary>
        [NameInMap("Internet")]
        [Validation(Required=false)]
        public string Internet { get; set; }

        /// <summary>
        /// <para>The billing method of an Internet-facing SLB instance. The following billing methods are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>PayBySpec</b>: Pay-by-specification.</description></item>
        /// <item><description><b>PayByCLCU</b>: Pay-by-CLCU.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayBySpec</para>
        /// </summary>
        [NameInMap("InternetSlbChargeType")]
        [Validation(Required=false)]
        public string InternetSlbChargeType { get; set; }

        /// <summary>
        /// <para>lb-bp1tg0k6d9nqaw7l1\<em>\</em>\<em>\</em></para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1tg0k6d9nqaw7l1****</para>
        /// </summary>
        [NameInMap("InternetSlbId")]
        [Validation(Required=false)]
        public string InternetSlbId { get; set; }

        /// <summary>
        /// <para>[{&quot;port&quot;:80,&quot;targetPort&quot;:8080,&quot;protocol&quot;:&quot;TCP&quot;}]</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;port&quot;:80,&quot;targetPort&quot;:8080,&quot;protocol&quot;:&quot;TCP&quot;}]</para>
        /// </summary>
        [NameInMap("Intranet")]
        [Validation(Required=false)]
        public string Intranet { get; set; }

        /// <summary>
        /// <para>The billing method of an Internal-facing SLB instance. The following billing methods are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>PayBySpec</b>: Pay-by-specification.</description></item>
        /// <item><description><b>PayByCLCU</b>: Pay-by-CLCU.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayBySpec</para>
        /// </summary>
        [NameInMap("IntranetSlbChargeType")]
        [Validation(Required=false)]
        public string IntranetSlbChargeType { get; set; }

        /// <summary>
        /// <para>lb-bp1tg0k6d9nqaw7l1\<em>\</em>\<em>\</em></para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1tg0k6d9nqaw7l1****</para>
        /// </summary>
        [NameInMap("IntranetSlbId")]
        [Validation(Required=false)]
        public string IntranetSlbId { get; set; }

    }

}
