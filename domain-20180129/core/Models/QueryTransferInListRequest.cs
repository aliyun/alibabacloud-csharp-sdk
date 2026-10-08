// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTransferInListRequest : TeaModel {
        /// <summary>
        /// <para>The domain name, which supports prefix matching (fuzzy query).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The language of error messages returned by the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number of the domain name list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The page size for paging the domain name list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Transfer status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: Submit transfer-in.  </description></item>
        /// <item><description><b>AUTHORIZATION</b>: Authorize transfer-in (email verification).  </description></item>
        /// <item><description><b>NAME_VERIFICATION</b>: Name review.  </description></item>
        /// <item><description><b>PASSWORD_VERIFICATION</b>: Transfer password verification.  </description></item>
        /// <item><description><b>PENDING</b>: Transfer-in in progress.  </description></item>
        /// <item><description><b>SUCCESS</b>: Transfer-in succeeded.  </description></item>
        /// <item><description><b>FAIL</b>: Transfer-in failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INIT</para>
        /// </summary>
        [NameInMap("SimpleTransferInStatus")]
        [Validation(Required=false)]
        public string SimpleTransferInStatus { get; set; }

        /// <summary>
        /// <para>End time for submitting the domain name list for transfer-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("SubmissionEndDate")]
        [Validation(Required=false)]
        public long? SubmissionEndDate { get; set; }

        /// <summary>
        /// <para>The start time for submitting the domain name list for transfer-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1514428524669</para>
        /// </summary>
        [NameInMap("SubmissionStartDate")]
        [Validation(Required=false)]
        public long? SubmissionStartDate { get; set; }

        /// <summary>
        /// <para>The user IP address, which can be set to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
