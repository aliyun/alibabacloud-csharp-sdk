// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateAgentGroupRequest : TeaModel {
        /// <summary>
        /// <para>说明：描述长度不能大于100,需进行UTF-8格式的URLEncode编码</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment3</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>说明：同一企业外呼组编号编号不能重复，外呼组编号长度为2-20，以字母开头,须同时且只能包含字母和数字 同一企业最多可创建1000个外呼组</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WH12</para>
        /// </summary>
        [NameInMap("Gno")]
        [Validation(Required=false)]
        public string Gno { get; set; }

        /// <summary>
        /// <para>说明：外呼组名称不能为空，长度不能大于50,需进行UTF-8格式的URLEncode编码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gpname1</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
