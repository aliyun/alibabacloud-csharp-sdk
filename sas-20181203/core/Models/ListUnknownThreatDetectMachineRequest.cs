// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUnknownThreatDetectMachineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-ecs</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>studying</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("StudyMode")]
        [Validation(Required=false)]
        public string StudyMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1768891966346</para>
        /// </summary>
        [NameInMap("StudyTimeEnd")]
        [Validation(Required=false)]
        public long? StudyTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1768891966344</para>
        /// </summary>
        [NameInMap("StudyTimeStart")]
        [Validation(Required=false)]
        public long? StudyTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d2d94e8b-bb25-4744-8004-1e08a53c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
