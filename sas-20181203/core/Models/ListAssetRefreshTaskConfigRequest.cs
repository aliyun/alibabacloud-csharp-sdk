// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetRefreshTaskConfigRequest : TeaModel {
        /// <summary>
        /// <para>The configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: host refresh task</description></item>
        /// <item><description><b>1</b>: cloud service refresh task</description></item>
        /// <item><description><b>2</b>: AccessKey scheduled verification task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RefreshConfigType")]
        [Validation(Required=false)]
        public int? RefreshConfigType { get; set; }

        /// <summary>
        /// <para>The region of the Security Center instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the AccessKey record specified when querying an AccessKey scheduled verification task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2295</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public long? TargetId { get; set; }

    }

}
