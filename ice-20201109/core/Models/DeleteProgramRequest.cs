// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteProgramRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChannel</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>program_name</para>
        /// </summary>
        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

    }

}
