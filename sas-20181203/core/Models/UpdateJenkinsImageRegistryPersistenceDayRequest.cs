// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateJenkinsImageRegistryPersistenceDayRequest : TeaModel {
        /// <summary>
        /// <para>The retention period. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PersistenceDay")]
        [Validation(Required=false)]
        public int? PersistenceDay { get; set; }

        /// <summary>
        /// <para>The image repository ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~PageImageRegistry~~">PageImageRegistry</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>25363</para>
        /// </summary>
        [NameInMap("RegistryId")]
        [Validation(Required=false)]
        public long? RegistryId { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106.11.XXX.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
