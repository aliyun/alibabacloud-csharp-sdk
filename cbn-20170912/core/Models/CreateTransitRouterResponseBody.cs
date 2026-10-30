// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>404DA7EC-F495-44B5-B543-6EDCDF90F3D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Enterprise Edition transit router instance ID, which is used to forward traffic and perform routing. After the instance is created, it is in the Creating state. You must wait until the instance enters the Active state before you can proceed to What to do next. You can invoke the ListTransitRouters operation to query the instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-uf6llz2286805i44g****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
