// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateKBSyncLinkResponseBody : TeaModel {
        /// <summary>
        /// <para>The client ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cli_xxxxxxbe8</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-14T05:58:42Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The source channel of the synchronization link. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FEISHU </description></item>
        /// <item><description>SHAREPOINT</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FEISHU</para>
        /// </summary>
        [NameInMap("ImPlatform")]
        [Validation(Required=false)]
        public string ImPlatform { get; set; }

        /// <summary>
        /// <para>The synchronization link ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkbl-xxxxxx</para>
        /// </summary>
        [NameInMap("LinkId")]
        [Validation(Required=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// <para>The name of the synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("LinkName")]
        [Validation(Required=false)]
        public string LinkName { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source directory address for synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.feishu.cn/wiki/space/xxxxxx">https://example.feishu.cn/wiki/space/xxxxxx</a></para>
        /// </summary>
        [NameInMap("SourceDir")]
        [Validation(Required=false)]
        public string SourceDir { get; set; }

        /// <summary>
        /// <para>The synchronization interval. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("SyncIntervalMinutes")]
        [Validation(Required=false)]
        public int? SyncIntervalMinutes { get; set; }

        /// <summary>
        /// <para>The synchronization status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATING</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>PAUSED</description></item>
        /// <item><description>DELETING</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATING</para>
        /// </summary>
        [NameInMap("SyncStatus")]
        [Validation(Required=false)]
        public string SyncStatus { get; set; }

    }

}
