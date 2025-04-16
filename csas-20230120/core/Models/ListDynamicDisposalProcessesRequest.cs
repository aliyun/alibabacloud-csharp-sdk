// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDynamicDisposalProcessesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("DisposalAction")]
        [Validation(Required=false)]
        public string DisposalAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dp-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DisposalProcessId")]
        [Validation(Required=false)]
        public string DisposalProcessId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743143296</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("RecoveryType")]
        [Validation(Required=false)]
        public string RecoveryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1743143296</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>disposal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xiaoming</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
