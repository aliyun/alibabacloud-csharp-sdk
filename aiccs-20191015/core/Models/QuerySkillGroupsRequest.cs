// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QuerySkillGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The channel type of the skill group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: All skill groups are returned.</description></item>
        /// <item><description><b>1</b>: Hotline skill group.</description></item>
        /// <item><description><b>2</b>: Online skill group.</description></item>
        /// <item><description><b>3</b>: Online + hotline skill group.</description></item>
        /// <item><description><b>4</b>: Ticket skill group.</description></item>
        /// <item><description><b>5</b>: Hotline + ticket skill group.</description></item>
        /// <item><description><b>6</b>: Online + ticket skill group.</description></item>
        /// <item><description><b>7</b>: Online + hotline + ticket skill group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public int? ChannelType { get; set; }

        /// <summary>
        /// <para>The unique ID of the client request. Used for idempotence verification. You can use a UUID to generate this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46c1341e-2648-447a-****-70b6a298d94d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1023****</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// <para>The ID of the AICCS instance.
        /// You can obtain the instance ID from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
