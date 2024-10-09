// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class TicketOrCredentialsSignInPopRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4546</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4546-100000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>会议名称</para>
        /// </summary>
        [NameInMap("ConferenceName")]
        [Validation(Required=false)]
        public string ConferenceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Z10</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>入口名称</para>
        /// </summary>
        [NameInMap("EntryName")]
        [Validation(Required=false)]
        public string EntryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>429005111100000</para>
        /// </summary>
        [NameInMap("Idcard")]
        [Validation(Required=false)]
        public string Idcard { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-25 14:11</para>
        /// </summary>
        [NameInMap("SignTime")]
        [Validation(Required=false)]
        public string SignTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
