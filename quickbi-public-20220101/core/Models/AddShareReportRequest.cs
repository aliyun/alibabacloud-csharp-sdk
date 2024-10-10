// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddShareReportRequest : TeaModel {
        /// <summary>
        /// <para>The scope of authorization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: view only</description></item>
        /// <item><description>3: View and export</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AuthPoint")]
        [Validation(Required=false)]
        public int? AuthPoint { get; set; }

        /// <summary>
        /// <para>The validity period of the share. The value is a timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608202110838</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// <para>The ID of the person to be shared, which may be the user ID of the Quick BI or the user group ID.</para>
        /// <list type="bullet">
        /// <item><description>If ShareToType is 0 (user), ShareTo is the user ID.</description></item>
        /// <item><description>When ShareToType is set to 1 (user group), ShareTo is the user group ID.</description></item>
        /// <item><description>When ShareToType=2 (organization), ShareTo is the ID of the organization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
        /// </summary>
        [NameInMap("ShareToId")]
        [Validation(Required=false)]
        public string ShareToId { get; set; }

        /// <summary>
        /// <para>The share type of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: user</description></item>
        /// <item><description>1: user group</description></item>
        /// <item><description>2: organization</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ShareToType")]
        [Validation(Required=false)]
        public int? ShareToType { get; set; }

        /// <summary>
        /// <para>The ID of the shared work. The works here include BI portal, dashboards, spreadsheets, and self-service access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b407e50-e774-406b-9956-da2425c2****</para>
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
