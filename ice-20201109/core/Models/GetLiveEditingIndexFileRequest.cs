// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveEditingIndexFileRequest : TeaModel {
        /// <summary>
        /// <para>The application name of the live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testrecord</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The domain name of the live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.alivecdn.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the live stream editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>cb6307a4edea614d8b3f3c</b></b></em></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>teststream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
