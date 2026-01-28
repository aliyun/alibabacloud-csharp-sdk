// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceAccount : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        [NameInMap("accountNotes")]
        [Validation(Required=false)]
        public string AccountNotes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>131243781293</para>
        /// </summary>
        [NameInMap("aliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("aliyunUserName")]
        [Validation(Required=false)]
        public string AliyunUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>创建时间</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public float? GmtCreate { get; set; }

        [NameInMap("orgs")]
        [Validation(Required=false)]
        public List<GrafanaWorkspaceUserOrg> Orgs { get; set; }

    }

}
