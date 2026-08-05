// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarFsResponseBody : TeaModel {
        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2035638*******</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The PolarFS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-2ze0i74ka607wck3</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

        /// <summary>
        /// <para>The PolarFS file system path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-xxx*******</para>
        /// </summary>
        [NameInMap("PolarFsPath")]
        [Validation(Required=false)]
        public string PolarFsPath { get; set; }

        /// <summary>
        /// <para>The PolarFS instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("PolarFsStatus")]
        [Validation(Required=false)]
        public string PolarFsStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CED079B7-A408-41A1-BFF1-EC608E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
