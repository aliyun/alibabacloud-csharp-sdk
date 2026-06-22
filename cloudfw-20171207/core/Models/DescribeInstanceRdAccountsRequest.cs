// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceRdAccountsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The remarks of the Cloud Firewall member accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>renewal</para>
        /// </summary>
        [NameInMap("MemberDesc")]
        [Validation(Required=false)]
        public string MemberDesc { get; set; }

        /// <summary>
        /// <para>The name of the Cloud Firewall member accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudfirewall_2</para>
        /// </summary>
        [NameInMap("MemberDisplayName")]
        [Validation(Required=false)]
        public string MemberDisplayName { get; set; }

        /// <summary>
        /// <para>The UID of the member accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The IP address of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.170.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
