// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListConversationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1638288000000</para>
        /// </summary>
        [NameInMap("BeginTimeLeftRange")]
        [Validation(Required=false)]
        public long? BeginTimeLeftRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1637547875311</para>
        /// </summary>
        [NameInMap("BeginTimeRightRange")]
        [Validation(Required=false)]
        public long? BeginTimeRightRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>138106*****</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>da37319b-6c83-4268-9f19-814aed62e401</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSandBox")]
        [Validation(Required=false)]
        public string IsSandBox { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13788914724</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public long? Result { get; set; }

        [NameInMap("RoundsLeftRange")]
        [Validation(Required=false)]
        public int? RoundsLeftRange { get; set; }

        [NameInMap("RoundsRightRange")]
        [Validation(Required=false)]
        public int? RoundsRightRange { get; set; }

    }

}
