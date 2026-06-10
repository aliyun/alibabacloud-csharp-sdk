// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DeleteContactWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>Contact whitelist ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08c32b67-43cd-4d6a-b7ea-d057xxxxxxxx</para>
        /// </summary>
        [NameInMap("ContactWhiteListId")]
        [Validation(Required=false)]
        public string ContactWhiteListId { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Operator information</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试人</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
