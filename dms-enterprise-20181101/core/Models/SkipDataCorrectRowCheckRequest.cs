// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SkipDataCorrectRowCheckRequest : TeaModel {
        /// <summary>
        /// <para>The ticket ID. You can call the <a href="https://help.aliyun.com/document_detail/144643.html">ListOrders</a> operation to obtain the ticket ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>420****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// <para>The reason for skipping the verification on the number of rows in the precheck for data change.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>save test time</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
