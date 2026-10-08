// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeADInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The DNS information of the AD domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.100.XX.XX</para>
        /// </summary>
        [NameInMap("ADDNS")]
        [Validation(Required=false)]
        public string ADDNS { get; set; }

        /// <summary>
        /// <para>The IP address of the AD domain server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("ADServerIpAddress")]
        [Validation(Required=false)]
        public string ADServerIpAddress { get; set; }

        /// <summary>
        /// <para>The status of the AD domain. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: The instance is being joined to the AD domain.</description></item>
        /// <item><description><b>0</b>: Failed to join the AD domain.</description></item>
        /// <item><description><b>1</b>: Joined the AD domain.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ADStatus")]
        [Validation(Required=false)]
        public string ADStatus { get; set; }

        /// <summary>
        /// <para>The reason for the exception.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AbnormalReason")]
        [Validation(Required=false)]
        public string AbnormalReason { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The username of the AD domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_01</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
