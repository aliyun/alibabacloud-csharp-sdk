// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkerListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The job information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkerListResponseBodyData Data { get; set; }
        public class GetWorkerListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The worker information.</para>
            /// </summary>
            [NameInMap("WorkerInfos")]
            [Validation(Required=false)]
            public List<GetWorkerListResponseBodyDataWorkerInfos> WorkerInfos { get; set; }
            public class GetWorkerListResponseBodyDataWorkerInfos : TeaModel {
                /// <summary>
                /// <para>The IP address of the worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30.225.16.49</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The label of the worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gray</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The port number of the worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60831</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The startup method of the worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>springboot</para>
                /// </summary>
                [NameInMap("Starter")]
                [Validation(Required=false)]
                public string Starter { get; set; }

                /// <summary>
                /// <para>The version of the worker.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.3.4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The address of the worker. The address is in the format of ${worker_id}@${worker_ip}:${worker_port}.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:030225016049_11734_25917@30.225.16.49">030225016049_11734_25917@30.225.16.49</a>:60831</para>
                /// </summary>
                [NameInMap("WorkerAddress")]
                [Validation(Required=false)]
                public string WorkerAddress { get; set; }

            }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cannot find product according to your domain.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F68ABED-AC31-4412-9297-D9A8F0401108****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call is successful.</description></item>
        /// <item><description><b>false</b>: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
