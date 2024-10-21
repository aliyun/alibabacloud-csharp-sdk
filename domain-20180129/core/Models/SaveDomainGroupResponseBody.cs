// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveDomainGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BeingDeleted")]
        [Validation(Required=false)]
        public bool? BeingDeleted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-04-02 15:59:06</para>
        /// </summary>
        [NameInMap("CreationDate")]
        [Validation(Required=false)]
        public string CreationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        [NameInMap("DomainGroupName")]
        [Validation(Required=false)]
        public string DomainGroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("DomainGroupStatus")]
        [Validation(Required=false)]
        public string DomainGroupStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-04-02 15:59:06</para>
        /// </summary>
        [NameInMap("ModificationDate")]
        [Validation(Required=false)]
        public string ModificationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80011ABC-F573-4795-B0E8-377BFBBA3422</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
