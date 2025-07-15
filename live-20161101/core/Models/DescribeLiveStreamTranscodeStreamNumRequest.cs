// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeStreamNumRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The grouping method.</para>
        /// <list type="bullet">
        /// <item><description>Domain name (default)</description></item>
        /// <item><description>Template</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domain</description></item>
        /// <item><description>template</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("SplitType")]
        [Validation(Required=false)]
        public string SplitType { get; set; }

    }

}
