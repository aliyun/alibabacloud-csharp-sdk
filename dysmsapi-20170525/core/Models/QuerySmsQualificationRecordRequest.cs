// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsQualificationRecordRequest : TeaModel {
        /// <summary>
        /// <para>The company name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云云通信有限公司</para>
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <para>The name of the legal representative.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李华</para>
        /// </summary>
        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The qualification name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云云通信有限公司李华</para>
        /// </summary>
        [NameInMap("QualificationGroupName")]
        [Validation(Required=false)]
        public string QualificationGroupName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The review status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INIT: Under review.</description></item>
        /// <item><description>NOT_PASS: Review rejected. </description></item>
        /// <item><description>PASS: Review approved.</description></item>
        /// <item><description>NOT_FINISH: Additional information required.</description></item>
        /// <item><description>CANCEL: Withdrawn.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PASS</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The purpose of the qualification application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: For self-use.</description></item>
        /// <item><description><b>false</b>: For use by others.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseBySelf")]
        [Validation(Required=false)]
        public bool? UseBySelf { get; set; }

        /// <summary>
        /// <para>The review ticket ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2001****</para>
        /// </summary>
        [NameInMap("WorkOrderId")]
        [Validation(Required=false)]
        public long? WorkOrderId { get; set; }

    }

}
