// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateGlobalDataNetworkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mygdn</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("DestinationFileSystemPath")]
        [Validation(Required=false)]
        public string DestinationFileSystemPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-xxx</para>
        /// </summary>
        [NameInMap("DestinationId")]
        [Validation(Required=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("DestinationRegion")]
        [Validation(Required=false)]
        public string DestinationRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FreezeSourceDuringSync")]
        [Validation(Required=false)]
        public string FreezeSourceDuringSync { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("SourceFileSystemPath")]
        [Validation(Required=false)]
        public string SourceFileSystemPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-xxx</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
