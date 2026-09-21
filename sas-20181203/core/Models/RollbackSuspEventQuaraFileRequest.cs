// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RollbackSuspEventQuaraFileRequest : TeaModel {
        /// <summary>
        /// <para>The source of the request. Set the value to sas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The ID of the quarantined file. You can call <a href="~~DescribeSuspEventQuaraFiles~~">DescribeSuspEventQuaraFiles</a> to obtain this value from the Id field in the response. This parameter is required. If this parameter is not specified, the API returns HTTP 400 with error code -101.</para>
        /// <para>Before you call this operation, make sure that the Security Center agent is installed on the ECS instance, and that file-related security events and corresponding quarantined files exist. After a file is quarantined, call DescribeSuspEventQuaraFiles to query the quarantined file ID, and then call this operation to restore the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3921797</para>
        /// </summary>
        [NameInMap("QuaraFileId")]
        [Validation(Required=false)]
        public int? QuaraFileId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member account in the resource directory.</para>
        /// <remarks>
        /// <para>You can call <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
