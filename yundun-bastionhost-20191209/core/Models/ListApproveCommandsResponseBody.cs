// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListApproveCommandsResponseBody : TeaModel {
        /// <summary>
        /// <para>The commands to be reviewed.</para>
        /// </summary>
        [NameInMap("ApproveCommands")]
        [Validation(Required=false)]
        public List<ListApproveCommandsResponseBodyApproveCommands> ApproveCommands { get; set; }
        public class ListApproveCommandsResponseBodyApproveCommands : TeaModel {
            /// <summary>
            /// <para>The ID of the command to be reviewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApproveCommandId")]
            [Validation(Required=false)]
            public string ApproveCommandId { get; set; }

            /// <summary>
            /// <para>The username of the asset account that is used for O\&amp;M.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root</para>
            /// </summary>
            [NameInMap("AssetAccountName")]
            [Validation(Required=false)]
            public string AssetAccountName { get; set; }

            /// <summary>
            /// <para>The IP address of the asset for O\&amp;M.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.167.XX.XX</para>
            /// </summary>
            [NameInMap("AssetIp")]
            [Validation(Required=false)]
            public string AssetIp { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>poros-test</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <para>The source IP address from which the application is submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.18.XX.XX</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The Bastionhost user who submitted the O\&amp;M application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClientUser")]
            [Validation(Required=false)]
            public string ClientUser { get; set; }

            /// <summary>
            /// <para>The command to be reviewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/bin/bash</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            /// <summary>
            /// <para>The time when the O\&amp;M application was submitted. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1679393152</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The O\&amp;M protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSH</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

            /// <summary>
            /// <para>The ID of the O\&amp;M session that triggered the review.</para>
            /// 
            /// <b>Example:</b>
            /// <para>95f873ab64a76d5b0000000000004d5e</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The status of the review. Valid values: <b>Wait</b>: The command is pending review.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Wait</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3EF7711-766D-5888-997B-EFBA76809229</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of commands to be reviewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
