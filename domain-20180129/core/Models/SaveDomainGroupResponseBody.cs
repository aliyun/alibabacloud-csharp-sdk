// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveDomainGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the group is being deleted.  </para>
        /// <remarks>
        /// <para>For groups containing more than 1,000 domain names, deletion is an asynchronous procedure that requires some time for the system to process. During this period, this field is <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BeingDeleted")]
        [Validation(Required=false)]
        public bool? BeingDeleted { get; set; }

        /// <summary>
        /// <para>Creation Time of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-02 15:59:06</para>
        /// </summary>
        [NameInMap("CreationDate")]
        [Validation(Required=false)]
        public string CreationDate { get; set; }

        /// <summary>
        /// <para>Domain group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DomainGroupId")]
        [Validation(Required=false)]
        public long? DomainGroupId { get; set; }

        /// <summary>
        /// <para>Domain Name Group Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试分组</para>
        /// </summary>
        [NameInMap("DomainGroupName")]
        [Validation(Required=false)]
        public string DomainGroupName { get; set; }

        /// <summary>
        /// <para>Status of the domain name group. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>PROCESSING</b>: Processing;  </description></item>
        /// <item><description><b>COMPLETE</b>: Complete.</description></item>
        /// </list>
        /// <remarks>
        /// <para>In cases such as setting a group via a file or replacing a group with more than 1,000 domain names, the operation is asynchronous and requires waiting for system processing. During this time, this field is <b>PROCESSING</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("DomainGroupStatus")]
        [Validation(Required=false)]
        public string DomainGroupStatus { get; set; }

        /// <summary>
        /// <para>Updated At time of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-04-02 15:59:06</para>
        /// </summary>
        [NameInMap("ModificationDate")]
        [Validation(Required=false)]
        public string ModificationDate { get; set; }

        /// <summary>
        /// <para>Unique request identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80011ABC-F573-4795-B0E8-377BFBBA3422</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Quantity of domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
