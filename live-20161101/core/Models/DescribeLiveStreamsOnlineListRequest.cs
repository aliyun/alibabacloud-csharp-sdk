// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsOnlineListRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. You can view the application name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only specific parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: returns only the DomainName, AppName, StreamName, and PublishTime parameters.</description></item>
        /// <item><description><b>no</b>: returns all parameters. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("OnlyStream")]
        [Validation(Required=false)]
        public string OnlyStream { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 3000. Default value: 2000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The mode in which stream names are matched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>fuzzy</b> (default): fuzzy match</description></item>
        /// <item><description><b>strict</b>: exact match</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the live stream. You can specify only one live stream. You can view the stream name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The type of the streams to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b> (default): all streams</description></item>
        /// <item><description><b>raw</b>: source streams</description></item>
        /// <item><description><b>trans</b>: transcoded streams</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

    }

}
