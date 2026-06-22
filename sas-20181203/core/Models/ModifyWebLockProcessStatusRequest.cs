// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyWebLockProcessStatusRequest : TeaModel {
        /// <summary>
        /// <para>The identity is simultaneous processing of servers that have the same process. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Do not use simultaneous processing.</description></item>
        /// <item><description><b>1</b>: Use simultaneous processing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DealAll")]
        [Validation(Required=false)]
        public int? DealAll { get; set; }

        /// <summary>
        /// <para>The operation parameters for batch setting the tamper-proofing process status. The value is in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;processPath&quot;:&quot;/etc/test1&quot;,&quot;uuid&quot;:&quot;0c1714dc-f7a3-4265-8364-7aa3fce8****&quot;},{&quot;processPath&quot;:&quot;/etc/test2&quot;,&quot;uuid&quot;:&quot;1cc45e7d-7698-4b2c-89d8-e8cba407****&quot;}]</para>
        /// </summary>
        [NameInMap("OperateInfo")]
        [Validation(Required=false)]
        public string OperateInfo { get; set; }

        /// <summary>
        /// <para>The list of process paths.</para>
        /// </summary>
        [NameInMap("ProcessPath")]
        [Validation(Required=false)]
        public List<string> ProcessPath { get; set; }

        /// <summary>
        /// <para>The status of the tamper-proofing process. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Remove from the whitelist.</description></item>
        /// <item><description><b>1</b>: Add to the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The UUID of the server for which you want to set the tamper-proofing process status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bc8510e7-7327-4030-b75c-956e434d****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
